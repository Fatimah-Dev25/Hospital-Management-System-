using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
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
    public partial class frmUserRoleManage : Form
    {
        RolesService rolesService;
        List<(int RoleID, string Role)> _RolesList;
        public frmUserRoleManage()
        {
            rolesService = new RolesService();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserRoleManage_Load(object sender, EventArgs e)
        {
            _LoadRolesGrid();
        }

        private void _LoadRolesGrid()
        {
            _RolesList = rolesService.GetAllUsersRole();

            dgvAllRoles.DataSource = _RolesList.Select(item => new
            {
                item.RoleID,
                item.Role
            }).ToList();


            dgvAllRoles.Columns[1].Width = 240;
        }

        private void viewPermissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasManageRolePermission(ManageRolePermissions.ManagePermissions))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            int roleID = Convert.ToInt32(dgvAllRoles.CurrentRow.Cells[0].Value);
            
            var frm = new frmViewPermissions(roleID);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int roleID = Convert.ToInt32(dgvAllRoles.CurrentRow.Cells[0].Value);

            var frm = new frmEditRole(roleID);
            frm.ShowDialog();
        }
    }
}
