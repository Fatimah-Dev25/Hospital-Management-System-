using HospitalManagementSystem.Models;
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
    public partial class frmEditRole : Form
    {
        RolesService rolesService;
        private int _RoleID;
        public frmEditRole(int roleID)
        {
            rolesService = new RolesService();
            _RoleID = roleID;
            InitializeComponent();
        }

        private void frmEditRole_Load(object sender, EventArgs e)
        {
            _LoadRoleData();
        }

        private void _LoadRoleData()
        {
            string roleName = rolesService.GetRoleByID(_RoleID);

            lblRoleID.Text = _RoleID.ToString();
            txtRoleName.Text = roleName;
            txtRoleName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoleName.Text)) { 
            
                MessageBox.Show("Must be entered Role Name in text box.", "Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(rolesService.UpdateRole(_RoleID, txtRoleName.Text, Global.CurrentUser.UsertId))
            {
                MessageBox.Show("Role Name has updated successfully.", "Role Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Role Name updated Failed.", "Role Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
