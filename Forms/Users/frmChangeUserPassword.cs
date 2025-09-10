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
    public partial class frmChangeUserPassword : Form
    {
        private int _UserID;
        UserService userService;
        User _userEntity;
        public frmChangeUserPassword(int userID)
        {
            InitializeComponent();

            _UserID = userID;
            userService = new UserService();
        }

        private void frmChangeUserPassword_Load(object sender, EventArgs e)
        {
            _FillUserInfoInControls();
        }

        private void _FillUserInfoInControls()
        {
            _userEntity = userService.GetUserInfoByID(_UserID);

            if (_userEntity == null)
            {


                MessageBox.Show($"There is no user with ID : {_UserID}, Try again.", "Not Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblUserID.Text = _userEntity.UsertId.ToString();
            lblUsername.Text = _userEntity.Username;
            lblPersonName.Text = _userEntity.RelatedPerson.Fullname;
            lblUserRole.Text = _userEntity.Role;
            rbActive.Checked = _userEntity.IsActive;

        }

        private bool _ValidateForm()
        {
            if (!(ValidationHelper.IsNotEmpty(txtCurrentPassword, errorProvider1) &&
                ValidationHelper.IsNotEmpty(txtNewPassword, errorProvider1) &&
                ValidationHelper.IsNotEmpty(txtConfirmPassword, errorProvider1)))
            {

                MessageBox.Show("Check Form, There are some fields are required.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_userEntity.PasswordHash != SecuritySettings.HashPassword(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txtCurrentPassword, "The current password you entered is incorrect.");
                return false;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {

                MessageBox.Show("New Password and Confirm Password don't match, check them please.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
                return;



            if (userService.ChangePassword(_userEntity.UsertId, SecuritySettings.HashPassword(txtNewPassword.Text), Global.CurrentUser.UsertId))
            {
                MessageBox.Show("User Password has updated Successfully.", "Change Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User Password has updated Failed.", "Change Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void view1_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = false;
        }

        private void view2_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void view3_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
        }
    }
    
}
