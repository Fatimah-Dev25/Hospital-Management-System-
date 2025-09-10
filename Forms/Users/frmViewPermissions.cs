using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Users
{
    public partial class frmViewPermissions : Form
    {
        private int _RoleID;
        PermissionTypeService _PermissionTypeService;
        PermissionsService _PermissionsService;
        RolePermissionsService _RolesService;
        private Dictionary<int, List<CheckBox>> _permissionTypeCheckBoxes;
        public frmViewPermissions(int roleID)
        {
            InitializeComponent();

            _RoleID = roleID;
            _PermissionsService = new PermissionsService();
            _RolesService = new RolePermissionsService();
            _PermissionTypeService = new PermissionTypeService();
            _permissionTypeCheckBoxes = new Dictionary<int, List<CheckBox>>();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewPermissions_Load(object sender, EventArgs e)
        {
            _LoadAllPermissions();
        }

        private void _LoadAllPermissions()
        {
            var permissionTypes = _PermissionTypeService.GetPermissionTypes();
            var rolePermissions = _RolesService.GetRolePermissions(_RoleID);

            foreach (var type in permissionTypes)
            {
                Label lblType = new Label
                {
                    Text = type.Type,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(5, 0, 10, 0)
                };
                flpAllPermissions.Controls.Add(lblType);
                Label spacer = new Label
                {
                    AutoSize = false,
                    Height = 10, 
                    Width = flpAllPermissions.ClientSize.Width
                };
                flpAllPermissions.Controls.Add(spacer);


                FlowLayoutPanel permissionPanel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    WrapContents = true,
                    Margin = new Padding(10, 0, 0, 20)
                };

                var permissions = _PermissionsService.GetPermissionsListByTypeID(type.ID);

                int existingValue = 0;
                var match = rolePermissions.FirstOrDefault(rp => rp.pType == type.ID);
                if (match != default) 
                {
                    existingValue = match.pValue;
                }

                var checkboxes = new List<CheckBox>();
                foreach (var perm in permissions)
                {
                    CheckBox cb = new CheckBox
                    {
                        Text = perm.Permission,
                        Tag = perm.PermissionValue,
                        Checked = (existingValue & perm.PermissionValue) != 0,
                        AutoSize = true,
                        Margin = new Padding(10, 5, 10, 5)
                    };
                    permissionPanel.Controls.Add(cb);
                    checkboxes.Add(cb);
                }

                flpAllPermissions.Controls.Add(permissionPanel);
                _permissionTypeCheckBoxes[type.ID] = checkboxes;
            }

        }

        private void flpAllPermissions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var updatedPermissions = new List<(int PermissionTypeID, int PermissionValue)>();

            foreach (var kvp in _permissionTypeCheckBoxes)
            {
                int permissionTypeId = kvp.Key;
                int combinedValue = 0;

                foreach (var cb in kvp.Value)
                {
                    int value = (int)cb.Tag;
                    if (cb.Checked)
                        combinedValue |= value;
                }

                updatedPermissions.Add((permissionTypeId, combinedValue));
            }

            if(_RolesService.AddOrUpdateRolePermissions(_RoleID, updatedPermissions, 1))
            {
                MessageBox.Show("Role Permissions have updated Successfully.", "Update Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Role Permissions updated Failed.", "Update Permissions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
