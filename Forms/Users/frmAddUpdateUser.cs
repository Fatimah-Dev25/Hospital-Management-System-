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
    public partial class frmAddUpdateUser : Form
    {
        enum Mode { AddNewUser, UpdateUser}
        Mode _formMode = Mode.AddNewUser;
        private int _UserID;
        UserService _userService;
        List<(int ID, string Role)> _RolesList;
        User userEntity;
        public frmAddUpdateUser(int userID = -1)
        {
            InitializeComponent();
            _userService = new UserService();
          
            if (userID > -1)
            {
                _UserID = userID;
                _formMode = Mode.UpdateUser;
            }
            else
            {
                _formMode = Mode.AddNewUser;
            }
        }
   

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _FillDefaultValues();

            if (_formMode == Mode.UpdateUser)
                _LoadData();
        }

        private void _LoadData()
        {
            userEntity = _userService.GetUserInfoByID(_UserID);

            if(userEntity == null)
            {
                MessageBox.Show("There is no user with ID = " +  _UserID + ". ", "Not Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblUserID.Text = userEntity.UsertId.ToString();
            txtUsername.Text = userEntity.Username;
            cbUserRoles.SelectedValue = userEntity.RoleID;
            rbIsUserActive.Checked = userEntity.IsActive;
            personCardWithFilter1.LoadPersonInfo(userEntity.PersonID);
            tcUserSettings.SelectedIndex = 1;
            tpUserInfo.Enabled = true;
            btnSave.Enabled = true;
            btnViewPassword.Visible = false;
            btnViewConfirmPassword.Visible = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
        }

        private void _FillDefaultValues()
        {
            lblUserID.Text = "[??]";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            btnSave.Enabled = false;

            _FillRolesInComboBox();

            if (_formMode == Mode.AddNewUser) {

                this.Text = "Add New User";
                lblFormTitle.Text = this.Text;
                personCardWithFilter1.FilterEnabled = true;

                userEntity = new User();
                tcUserSettings.SelectedIndex = 0;
                tpUserInfo.Enabled = false;
            }
        }

        private void _FillRolesInComboBox()
        {
            _RolesList = _userService.GetUserRoles();

            cbUserRoles.DataSource = _RolesList.Select(item => new { item.ID, item.Role }).ToList();

            cbUserRoles.DisplayMember = "Role";
            cbUserRoles.ValueMember = "ID";
        }

        private void personCardWithFilter1_onPersonSelected(int obj)
        {
            if (_formMode == Mode.AddNewUser)
            {
                if (_userService.IsUserExistsByPersonID(obj))
                {

                    MessageBox.Show("This person already user, please choose another person.",
                        "Person Has Account",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            tcUserSettings.SelectedIndex = 1;
            tpUserInfo.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; 
        }

        private void btnViewConfirmPassword_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
        }


        private bool _ValidateForm()
        {
            if (_formMode == Mode.AddNewUser)
            {
                if (!(ValidationHelper.IsNotEmpty(txtUsername, errorProvider1) &&
                 ValidationHelper.IsNotEmpty(txtPassword, errorProvider1) &&
                 ValidationHelper.IsNotEmpty(txtConfirmPassword, errorProvider1)))
                {
                    MessageBox.Show("Check Form, There is field required!", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            else
            {
                if(!ValidationHelper.IsNotEmpty(txtUsername, errorProvider1))
                {
                    MessageBox.Show("Check Form, There is field required!", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                return true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
                return;

            if (_userService.CheckUsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username already exists, please change it.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _MapDataToModel();

            switch (_formMode) {

                case Mode.AddNewUser:
                    {
                        userEntity.UsertId = _userService.AddUser(userEntity, Global.CurrentUser.UsertId);
                        if (userEntity.UsertId > 0)
                        {
                            lblUserID.Text = userEntity.UsertId.ToString();
                            _formMode = Mode.UpdateUser;
                            lblFormTitle.Text = this.Text = "Update User Info";

                            MessageBox.Show("User added Successful.", "Success Add",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User added Failed.", "Fail Add",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                case Mode.UpdateUser:
                    {
                        if(_userService.UpdateUserInfoByID(userEntity, Global.CurrentUser.UsertId))
                        {
                            MessageBox.Show("User Updated Successful.", "Success Update",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User Updated Failed.", "Fail Update",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                          
                        break;
                    }
            }
        }

        private void _MapDataToModel()
        {
            userEntity.Username = txtUsername.Text;
            userEntity.PersonID = personCardWithFilter1.PersonID;
            userEntity.PasswordHash = SecuritySettings.HashPassword(txtPassword.Text);
            userEntity.RoleID = Convert.ToInt32(cbUserRoles.SelectedValue);
            userEntity.IsActive = rbIsUserActive.Checked;
        }
    }
}
