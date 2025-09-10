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
    public partial class frmShowUserDetail : Form
    {
        private int _UserID;
        private UserService _service;
        private Models.User _user;
        public frmShowUserDetail(int userID)
        {
            InitializeComponent();
            _UserID = userID;
            _service = new UserService();
        }

        private void frmShowUserDetail_Load(object sender, EventArgs e)
        {
            _user = _service.GetUserInfoByID(_UserID);

            if (_user == null) {

                MessageBox.Show($"There is no exits User with ID: {_UserID}.", "Not Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);

                return;
            }

            lblUserId.Text = _user.UsertId.ToString();
            lblUserName.Text = _user.Username;
            lblRole.Text = _user.Role;
            rbIsActive.Checked = _user.IsActive;
            ucPersonView1.LoadPersonInControl(_user.PersonID);
        }

    }
}
