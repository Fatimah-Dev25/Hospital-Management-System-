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
    public partial class frmUsersManagement : Form
    {
        UserService userService;
        DataTable _UsersList;
        public frmUsersManagement()
        {
            userService = new UserService();
            InitializeComponent();
        }

        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            _LoadUsersGrid();
        }

        private void _LoadUsersGrid()
        {
            _UsersList = userService.GetUsersList();
            dgvAllUsers.DataSource = _UsersList;
            
            dgvAllUsers.Columns[0].Width = 90;
            dgvAllUsers.Columns[1].Width = 90;
            dgvAllUsers.Columns[2].Width = 180;
            dgvAllUsers.Columns[3].Width = 130;
            dgvAllUsers.Columns[4].Width = 130;
            dgvAllUsers.Columns[5].Width = 130;

        }

        private void dgvAllUsers_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAllUsers.ClearSelection();
                dgvAllUsers.Rows[e.RowIndex].Selected = true;

                DataGridViewRow selectedRow = dgvAllUsers.Rows[e.RowIndex];

                bool isActive = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);

                if (isActive)
                {
                    activeToolStripMenuItem.Text = "Deactivate";
                }
                else
                {
                    activeToolStripMenuItem.Text = "Activate";
                }

                usersMenu.Show(Cursor.Position);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.UsersPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            var frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.UsersPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            int userID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value);

            var frm = new frmAddUpdateUser(userID);
            frm.ShowDialog();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value);

            bool userActive = Convert.ToBoolean(dgvAllUsers.CurrentRow.Cells["IsActive"].Value);

            if ((userActive))
            {
                if (userService.ChangeUserActivation(userID,false, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("User Deacivation Successful.", "User Deactivation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAllUsers.CurrentRow.Cells["IsActive"].Value = false;
                }
                else
                {

                    MessageBox.Show("User Deactivation Failed.", "User Deactivation",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (userService.ChangeUserActivation(userID, true, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("User Acivation Successful.", "User Activation",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvAllUsers.CurrentRow.Cells["IsActive"].Value = true;
                }
                else
                {

                    MessageBox.Show("User Activation Failed.", "User Activation",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.UsersPermissions, SubPermission.ChangePassword))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            int userID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value);

            var frm = new frmChangeUserPassword(userID);
            frm.ShowDialog();
        }

        private void btnRolesManage_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasManageRolePermission(ManageRolePermissions.ManageRoles))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            var frm = new frmUserRoleManage();
            frm.ShowDialog();
        }

        private void showUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.UsersPermissions, SubPermission.ViewItem))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            int userID = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value);
            
            var frm = new frmShowUserDetail(userID);
            frm.ShowDialog();
        }
    }
}
