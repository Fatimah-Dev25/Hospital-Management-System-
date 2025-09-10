using Guna.UI.WinForms;
using HospitalManagementSystem.Forms.Appointments;
using HospitalManagementSystem.Forms.AuditLogs;
using HospitalManagementSystem.Forms.Doctors;
using HospitalManagementSystem.Forms.Invoices;
using HospitalManagementSystem.Forms.LabTests;
using HospitalManagementSystem.Forms.MedicalRecords;
using HospitalManagementSystem.Forms.Patients;
using HospitalManagementSystem.Forms.StaffForms;
using HospitalManagementSystem.Forms.Users;
using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms
{
    public partial class frmMain : Form
    {
        frmLogin _LoginForm;
        private bool isCollapsed = false;
        private int expandedWidth = 230;  
        private int collapsedWidth = 60;
        public frmMain(frmLogin loginForm)
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializeDateTimeUpdater();
            _LoginForm = loginForm;

        }

        private void InitializeDateTimeUpdater()
        {
            systemTimer = new Timer();
            systemTimer.Interval = 1000; 
            systemTimer.Tick += systemTimer_Tick;
            systemTimer.Start();
        }

        private void btnViewUserMenu_Click(object sender, EventArgs e)
        {
            systemUserMenu.Show(btnViewUserMenu, new Point(0, btnViewUserMenu.Height));

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _LoadUserDetail();
            _ShowFormInPanel(new frmDashboard());
            _LoadUserPermissions();
        }

        private void _LoadUserPermissions()
        {
            RolePermissionsService rolePermissionsService = new RolePermissionsService();

            var allpermissions = rolePermissionsService.GetRolePermissions(Global.CurrentUser.RoleID);

            PermissionManager.CurrentUserPermissions = new List<(GeneralPermissions PermType, int CombineValues)> ();


            foreach (var permission in allpermissions) {

                PermissionManager.CurrentUserPermissions.Add(((GeneralPermissions)permission.pType, permission.pValue));
            }

        }

        private void _LoadUserDetail()
        {


            if (Global.CurrentUser == null) {

                return;
            }

            lblUsername.Text = Global.CurrentUser.Username;

            string path = Global.CurrentUser.RelatedPerson.ImagePath;

            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                pbUserProfile.Image = ResizeImage(Image.FromFile(path), pbUserProfile.Size);
            }
        }

        private Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }


        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmChangeUserPassword(Global.CurrentUser.UsertId);
            frm.ShowDialog();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelSidebar.Width = expandedWidth;
                isCollapsed = false;
                foreach (GunaButton btn in panelSidebar.Controls.OfType<GunaButton>())
                {
                    btn.Text = btn.Tag.ToString(); 
                    btn.ImageAlign = HorizontalAlignment.Left;

                }
                
            }
            else
            {
                // Collapse
                panelSidebar.Width = collapsedWidth;
                isCollapsed = true;
                foreach (GunaButton btn in panelSidebar.Controls.OfType<GunaButton>())
                {
                    btn.Text = "";
                    btn.ImageAlign = HorizontalAlignment.Center;
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
            
                this.Close();
                _LoginForm.Show();
            }
         
        }

        private void systemTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, yyyy-MM-dd HH:mm:ss");

        }

        private void _ShowFormInPanel(Form form)
        {
            panelMainContent.Controls.Clear();  
            form.TopLevel = false;               
            form.FormBorderStyle = FormBorderStyle.None;  
            form.Dock = DockStyle.Fill;          
            panelMainContent.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _ShowFormInPanel(new frmDashboard());
        }

        private void btnPatientManagement_Click(object sender, EventArgs e)
        {
            if(!PermissionManager.HasPermission(GeneralPermissions.PatientsPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmPatientManagement());
        }

        private void btnDoctorsManagement_Click_1(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.DoctorPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmDoctorsManagement());
        }

        private void btnSttaffManagement_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.StaffPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmStaffManagement());
        }

        private void btnAppointmentsManagement_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.AppointmentsPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmAppointmentsManagement());
        }

        private void btnMedicalRecordsManagement_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmMedicalRecordsManagement());
        }

        private void btnLabTestsManagement_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmLabTestsManagment());
        }

        private void btnInvoicesManagement_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.ViewAll))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmInvoicesManagement());
        }

        private void btnUsersManagement_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.UsersPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmUsersManagement());
        }


        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                var frm = new frmAddEditPatient();
                frm.ShowDialog();
                e.Handled = true;
            }
        }

        private void viewUserInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmShowUserDetail(Global.CurrentUser.UsertId);
            frm.ShowDialog();
        }

        private void btnAuditsManagement_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasAuiditLogsPermission(AuditLogsPermissions.ViewLogs))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            _ShowFormInPanel(new frmAuditLogsManagement());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            _ShowFormInPanel(new frmDashboard());

            MessageBox.Show("⚠️ This feature is not yet available.\r\nIt will be introduced in Version 2.0 of the Hospital Management System.",
                "📊 Reports Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            _ShowFormInPanel(new frmDashboard());

            MessageBox.Show("🔧 This section is currently under maintenance.\r\nPlease check back later for updates.",
                "⚙️ Settings Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
