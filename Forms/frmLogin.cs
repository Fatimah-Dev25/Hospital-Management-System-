using Guna.UI.WinForms;
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

namespace HospitalManagementSystem.Forms
{
    public partial class frmLogin : Form
    {
        UserService _userService;
        string _HashedPassword = "";
        bool _isPasswordShown = false;
        public frmLogin()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _ConnectControlsToParent();

            _FillStoredCredential();

        }

        private void _FillStoredCredential()
        {
            string username = "", hashedPassword = "";
            
            bool hasCredential = Global.GetStoredCredential(ref username, ref hashedPassword) &&
                     !string.IsNullOrEmpty(username) &&
                     !string.IsNullOrEmpty(hashedPassword);
            if (hasCredential)
            { 

                    txtUsername.Text = username;
                    cbRememberme.Checked = true;
                    _HashedPassword = hashedPassword;
                    txtPassword.BackColor = Color.Gray;
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.Text = "************************************";
                    txtPassword.Enabled = true;
                    viewPassword.Enabled = false;
                    llblLoginAnotherAccount.Visible = true;

                
               
            }
            else
            {
                cbRememberme.Checked = false;
                llblLoginAnotherAccount.Visible= false;
                viewPassword.Enabled = true;
            }
                
        }

        private void _ConnectControlsToParent()
        {
            pictureBox1.Parent = gunaGradientTileButton1;
            pictureBox1.BackColor = Color.Transparent;
            label1.Parent = gunaGradientTileButton1;
            label1.BackColor = Color.Transparent;
            label2.Parent = gunaGradientTileButton1;
            label2.BackColor = Color.Transparent;
            label3.Parent = gunaGradientTileButton1;
            label3.BackColor = Color.Transparent;
   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string hashedPassword = string.IsNullOrEmpty(_HashedPassword)?
                SecuritySettings.HashPassword(txtPassword.Text.Trim()):_HashedPassword;

            User user = _userService.GetUserByCredentials(txtUsername.Text.Trim(), hashedPassword);

            if (user != null)
            {
                if (cbRememberme.Checked)
                {
                    Global.RememberUsernameAndPassword(txtUsername.Text.Trim(), hashedPassword);
                
                }
                else
                    Global.RememberUsernameAndPassword("", "");

                if (!user.IsActive)
                {
                    txtUsername.Focus();
                    MessageBox.Show("Your account is not active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Global.CurrentUser = user;
                this.Hide();
                frmMain frm = new frmMain(this);
                frm.ShowDialog();
            }
            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewPassword_Click(object sender, EventArgs e)
        {
            if (_isPasswordShown)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '●';
                _isPasswordShown = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                _isPasswordShown = true;
                txtPassword.UseSystemPasswordChar = false;
            }
            
        }

        private void llblLoginAnotherAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbRememberme.Checked = false;
            txtUsername.Focus();
        }
    }
}
