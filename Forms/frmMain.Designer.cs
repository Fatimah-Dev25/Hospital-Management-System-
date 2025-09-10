namespace HospitalManagementSystem.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.systemUserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewUserInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnDashboard = new Guna.UI.WinForms.GunaButton();
            this.btnInvoicesManagement = new Guna.UI.WinForms.GunaButton();
            this.btnSttaffManagement = new Guna.UI.WinForms.GunaButton();
            this.btnSettings = new Guna.UI.WinForms.GunaButton();
            this.btnReports = new Guna.UI.WinForms.GunaButton();
            this.btnAuditsManagement = new Guna.UI.WinForms.GunaButton();
            this.btnUsersManagement = new Guna.UI.WinForms.GunaButton();
            this.btnLabTestsManagement = new Guna.UI.WinForms.GunaButton();
            this.btnMedicalRecordsManagement = new Guna.UI.WinForms.GunaButton();
            this.btnAppointmentsManagement = new Guna.UI.WinForms.GunaButton();
            this.btnDoctorsManagement = new Guna.UI.WinForms.GunaButton();
            this.btnPatientManagement = new Guna.UI.WinForms.GunaButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainHeader = new System.Windows.Forms.Panel();
            this.btnToggle = new System.Windows.Forms.PictureBox();
            this.btnViewUserMenu = new System.Windows.Forms.PictureBox();
            this.pbUserProfile = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainFooter = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAppNameVersion = new System.Windows.Forms.Label();
            this.systemTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.systemUserMenu.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.MainHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewUserMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemUserMenu
            // 
            this.systemUserMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.systemUserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUserInfoToolStripMenuItem1,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.systemUserMenu.Name = "systemUserMenu";
            this.systemUserMenu.Size = new System.Drawing.Size(203, 82);
            // 
            // viewUserInfoToolStripMenuItem1
            // 
            this.viewUserInfoToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.viewUserInfoToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.viewUserInfoToolStripMenuItem1.Image = global::HospitalManagementSystem.Properties.Resources.page;
            this.viewUserInfoToolStripMenuItem1.Name = "viewUserInfoToolStripMenuItem1";
            this.viewUserInfoToolStripMenuItem1.Size = new System.Drawing.Size(202, 26);
            this.viewUserInfoToolStripMenuItem1.Text = "Show User Detail";
            this.viewUserInfoToolStripMenuItem1.Click += new System.EventHandler(this.viewUserInfoToolStripMenuItem1_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.changePasswordToolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.reset_password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.logoutToolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.check_out;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(161)))), ((int)(((byte)(217)))));
            this.panelSidebar.Controls.Add(this.btnDashboard);
            this.panelSidebar.Controls.Add(this.btnInvoicesManagement);
            this.panelSidebar.Controls.Add(this.btnSttaffManagement);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnReports);
            this.panelSidebar.Controls.Add(this.btnAuditsManagement);
            this.panelSidebar.Controls.Add(this.btnUsersManagement);
            this.panelSidebar.Controls.Add(this.btnLabTestsManagement);
            this.panelSidebar.Controls.Add(this.btnMedicalRecordsManagement);
            this.panelSidebar.Controls.Add(this.btnAppointmentsManagement);
            this.panelSidebar.Controls.Add(this.btnDoctorsManagement);
            this.panelSidebar.Controls.Add(this.btnPatientManagement);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(281, 814);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.AnimationHoverSpeed = 0.07F;
            this.btnDashboard.AnimationSpeed = 0.03F;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.Black;
            this.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashboard.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::HospitalManagementSystem.Properties.Resources.icons8_dashboard_layout_32;
            this.btnDashboard.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDashboard.Location = new System.Drawing.Point(0, 116);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnDashboard.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnDashboard.OnHoverImage = null;
            this.btnDashboard.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnDashboard.Size = new System.Drawing.Size(281, 55);
            this.btnDashboard.TabIndex = 10;
            this.btnDashboard.Tag = "Dashboard";
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnInvoicesManagement
            // 
            this.btnInvoicesManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoicesManagement.AnimationHoverSpeed = 0.07F;
            this.btnInvoicesManagement.AnimationSpeed = 0.03F;
            this.btnInvoicesManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnInvoicesManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnInvoicesManagement.BorderColor = System.Drawing.Color.Black;
            this.btnInvoicesManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnInvoicesManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnInvoicesManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicesManagement.ForeColor = System.Drawing.Color.White;
            this.btnInvoicesManagement.Image = global::HospitalManagementSystem.Properties.Resources.invoice__4_;
            this.btnInvoicesManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnInvoicesManagement.Location = new System.Drawing.Point(0, 516);
            this.btnInvoicesManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnInvoicesManagement.Name = "btnInvoicesManagement";
            this.btnInvoicesManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnInvoicesManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnInvoicesManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnInvoicesManagement.OnHoverImage = null;
            this.btnInvoicesManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnInvoicesManagement.Size = new System.Drawing.Size(281, 55);
            this.btnInvoicesManagement.TabIndex = 9;
            this.btnInvoicesManagement.Tag = "     Invoices & Payments";
            this.btnInvoicesManagement.Text = "     Invoices & Payments";
            this.btnInvoicesManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnInvoicesManagement.Click += new System.EventHandler(this.btnInvoicesManagement_Click);
            // 
            // btnSttaffManagement
            // 
            this.btnSttaffManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSttaffManagement.AnimationHoverSpeed = 0.07F;
            this.btnSttaffManagement.AnimationSpeed = 0.03F;
            this.btnSttaffManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnSttaffManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnSttaffManagement.BorderColor = System.Drawing.Color.Black;
            this.btnSttaffManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSttaffManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnSttaffManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSttaffManagement.ForeColor = System.Drawing.Color.White;
            this.btnSttaffManagement.Image = global::HospitalManagementSystem.Properties.Resources.staff_management;
            this.btnSttaffManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnSttaffManagement.Location = new System.Drawing.Point(0, 288);
            this.btnSttaffManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnSttaffManagement.Name = "btnSttaffManagement";
            this.btnSttaffManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnSttaffManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSttaffManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnSttaffManagement.OnHoverImage = null;
            this.btnSttaffManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnSttaffManagement.Size = new System.Drawing.Size(281, 55);
            this.btnSttaffManagement.TabIndex = 8;
            this.btnSttaffManagement.Tag = "Staff Management";
            this.btnSttaffManagement.Text = "Staff Management";
            this.btnSttaffManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSttaffManagement.Click += new System.EventHandler(this.btnSttaffManagement_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.AnimationHoverSpeed = 0.07F;
            this.btnSettings.AnimationSpeed = 0.03F;
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnSettings.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.FocusedColor = System.Drawing.Color.Empty;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::HospitalManagementSystem.Properties.Resources.settings;
            this.btnSettings.ImageSize = new System.Drawing.Size(28, 28);
            this.btnSettings.Location = new System.Drawing.Point(0, 744);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnSettings.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnSettings.OnHoverImage = null;
            this.btnSettings.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnSettings.Size = new System.Drawing.Size(281, 55);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.AnimationHoverSpeed = 0.07F;
            this.btnReports.AnimationSpeed = 0.03F;
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnReports.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnReports.BorderColor = System.Drawing.Color.Black;
            this.btnReports.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReports.FocusedColor = System.Drawing.Color.Empty;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = global::HospitalManagementSystem.Properties.Resources.documents;
            this.btnReports.ImageSize = new System.Drawing.Size(28, 28);
            this.btnReports.Location = new System.Drawing.Point(0, 630);
            this.btnReports.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnReports.Name = "btnReports";
            this.btnReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnReports.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnReports.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnReports.OnHoverImage = null;
            this.btnReports.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnReports.Size = new System.Drawing.Size(281, 55);
            this.btnReports.TabIndex = 6;
            this.btnReports.Tag = "Reports";
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAuditsManagement
            // 
            this.btnAuditsManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuditsManagement.AnimationHoverSpeed = 0.07F;
            this.btnAuditsManagement.AnimationSpeed = 0.03F;
            this.btnAuditsManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnAuditsManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnAuditsManagement.BorderColor = System.Drawing.Color.Black;
            this.btnAuditsManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAuditsManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnAuditsManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditsManagement.ForeColor = System.Drawing.Color.White;
            this.btnAuditsManagement.Image = global::HospitalManagementSystem.Properties.Resources.audit_processes;
            this.btnAuditsManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAuditsManagement.Location = new System.Drawing.Point(0, 687);
            this.btnAuditsManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAuditsManagement.Name = "btnAuditsManagement";
            this.btnAuditsManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnAuditsManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAuditsManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnAuditsManagement.OnHoverImage = null;
            this.btnAuditsManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnAuditsManagement.Size = new System.Drawing.Size(281, 55);
            this.btnAuditsManagement.TabIndex = 5;
            this.btnAuditsManagement.Tag = "Audit Logs";
            this.btnAuditsManagement.Text = "Audit Logs";
            this.btnAuditsManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAuditsManagement.Click += new System.EventHandler(this.btnAuditsManagement_Click);
            // 
            // btnUsersManagement
            // 
            this.btnUsersManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsersManagement.AnimationHoverSpeed = 0.07F;
            this.btnUsersManagement.AnimationSpeed = 0.03F;
            this.btnUsersManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnUsersManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnUsersManagement.BorderColor = System.Drawing.Color.Black;
            this.btnUsersManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsersManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnUsersManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersManagement.ForeColor = System.Drawing.Color.White;
            this.btnUsersManagement.Image = global::HospitalManagementSystem.Properties.Resources.team_management;
            this.btnUsersManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnUsersManagement.Location = new System.Drawing.Point(0, 573);
            this.btnUsersManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnUsersManagement.Name = "btnUsersManagement";
            this.btnUsersManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnUsersManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnUsersManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnUsersManagement.OnHoverImage = null;
            this.btnUsersManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnUsersManagement.Size = new System.Drawing.Size(281, 55);
            this.btnUsersManagement.TabIndex = 4;
            this.btnUsersManagement.Tag = "Users & Roles";
            this.btnUsersManagement.Text = "Users & Roles";
            this.btnUsersManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUsersManagement.Click += new System.EventHandler(this.btnUsersManagement_Click);
            // 
            // btnLabTestsManagement
            // 
            this.btnLabTestsManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLabTestsManagement.AnimationHoverSpeed = 0.07F;
            this.btnLabTestsManagement.AnimationSpeed = 0.03F;
            this.btnLabTestsManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnLabTestsManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnLabTestsManagement.BorderColor = System.Drawing.Color.Black;
            this.btnLabTestsManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLabTestsManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnLabTestsManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabTestsManagement.ForeColor = System.Drawing.Color.White;
            this.btnLabTestsManagement.Image = global::HospitalManagementSystem.Properties.Resources.experiment;
            this.btnLabTestsManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnLabTestsManagement.Location = new System.Drawing.Point(0, 459);
            this.btnLabTestsManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnLabTestsManagement.Name = "btnLabTestsManagement";
            this.btnLabTestsManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnLabTestsManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLabTestsManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnLabTestsManagement.OnHoverImage = null;
            this.btnLabTestsManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnLabTestsManagement.Size = new System.Drawing.Size(281, 55);
            this.btnLabTestsManagement.TabIndex = 3;
            this.btnLabTestsManagement.Tag = "Lab Tests";
            this.btnLabTestsManagement.Text = "Lab Tests";
            this.btnLabTestsManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLabTestsManagement.Click += new System.EventHandler(this.btnLabTestsManagement_Click);
            // 
            // btnMedicalRecordsManagement
            // 
            this.btnMedicalRecordsManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMedicalRecordsManagement.AnimationHoverSpeed = 0.07F;
            this.btnMedicalRecordsManagement.AnimationSpeed = 0.03F;
            this.btnMedicalRecordsManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnMedicalRecordsManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnMedicalRecordsManagement.BorderColor = System.Drawing.Color.Black;
            this.btnMedicalRecordsManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMedicalRecordsManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnMedicalRecordsManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicalRecordsManagement.ForeColor = System.Drawing.Color.White;
            this.btnMedicalRecordsManagement.Image = global::HospitalManagementSystem.Properties.Resources.medical_prescription;
            this.btnMedicalRecordsManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnMedicalRecordsManagement.Location = new System.Drawing.Point(0, 402);
            this.btnMedicalRecordsManagement.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnMedicalRecordsManagement.Name = "btnMedicalRecordsManagement";
            this.btnMedicalRecordsManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnMedicalRecordsManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMedicalRecordsManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnMedicalRecordsManagement.OnHoverImage = null;
            this.btnMedicalRecordsManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnMedicalRecordsManagement.Size = new System.Drawing.Size(281, 55);
            this.btnMedicalRecordsManagement.TabIndex = 2;
            this.btnMedicalRecordsManagement.Tag = "Medical Records";
            this.btnMedicalRecordsManagement.Text = "Medical Records";
            this.btnMedicalRecordsManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMedicalRecordsManagement.Click += new System.EventHandler(this.btnMedicalRecordsManagement_Click);
            // 
            // btnAppointmentsManagement
            // 
            this.btnAppointmentsManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentsManagement.AnimationHoverSpeed = 0.07F;
            this.btnAppointmentsManagement.AnimationSpeed = 0.03F;
            this.btnAppointmentsManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnAppointmentsManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnAppointmentsManagement.BorderColor = System.Drawing.Color.Black;
            this.btnAppointmentsManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAppointmentsManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnAppointmentsManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentsManagement.ForeColor = System.Drawing.Color.White;
            this.btnAppointmentsManagement.Image = global::HospitalManagementSystem.Properties.Resources.event_management;
            this.btnAppointmentsManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAppointmentsManagement.Location = new System.Drawing.Point(0, 345);
            this.btnAppointmentsManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnAppointmentsManagement.Name = "btnAppointmentsManagement";
            this.btnAppointmentsManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnAppointmentsManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAppointmentsManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnAppointmentsManagement.OnHoverImage = null;
            this.btnAppointmentsManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnAppointmentsManagement.Size = new System.Drawing.Size(281, 55);
            this.btnAppointmentsManagement.TabIndex = 2;
            this.btnAppointmentsManagement.Tag = "Appointments";
            this.btnAppointmentsManagement.Text = "Appointments";
            this.btnAppointmentsManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAppointmentsManagement.Click += new System.EventHandler(this.btnAppointmentsManagement_Click);
            // 
            // btnDoctorsManagement
            // 
            this.btnDoctorsManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoctorsManagement.AnimationHoverSpeed = 0.07F;
            this.btnDoctorsManagement.AnimationSpeed = 0.03F;
            this.btnDoctorsManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnDoctorsManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnDoctorsManagement.BorderColor = System.Drawing.Color.Black;
            this.btnDoctorsManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDoctorsManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnDoctorsManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorsManagement.ForeColor = System.Drawing.Color.White;
            this.btnDoctorsManagement.Image = global::HospitalManagementSystem.Properties.Resources.medical_team1;
            this.btnDoctorsManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDoctorsManagement.Location = new System.Drawing.Point(0, 231);
            this.btnDoctorsManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnDoctorsManagement.Name = "btnDoctorsManagement";
            this.btnDoctorsManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnDoctorsManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnDoctorsManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnDoctorsManagement.OnHoverImage = null;
            this.btnDoctorsManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnDoctorsManagement.Size = new System.Drawing.Size(281, 55);
            this.btnDoctorsManagement.TabIndex = 1;
            this.btnDoctorsManagement.Tag = "    Doctor Management";
            this.btnDoctorsManagement.Text = "    Doctor Management";
            this.btnDoctorsManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDoctorsManagement.Click += new System.EventHandler(this.btnDoctorsManagement_Click_1);
            // 
            // btnPatientManagement
            // 
            this.btnPatientManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientManagement.AnimationHoverSpeed = 0.07F;
            this.btnPatientManagement.AnimationSpeed = 0.03F;
            this.btnPatientManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(99)))), ((int)(((byte)(128)))));
            this.btnPatientManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnPatientManagement.BorderColor = System.Drawing.Color.Black;
            this.btnPatientManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPatientManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnPatientManagement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientManagement.ForeColor = System.Drawing.Color.White;
            this.btnPatientManagement.Image = global::HospitalManagementSystem.Properties.Resources.icons8_clinic_32;
            this.btnPatientManagement.ImageSize = new System.Drawing.Size(28, 28);
            this.btnPatientManagement.Location = new System.Drawing.Point(0, 174);
            this.btnPatientManagement.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnPatientManagement.Name = "btnPatientManagement";
            this.btnPatientManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(179)))), ((int)(((byte)(224)))));
            this.btnPatientManagement.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnPatientManagement.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(98)))), ((int)(((byte)(143)))));
            this.btnPatientManagement.OnHoverImage = null;
            this.btnPatientManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.btnPatientManagement.Size = new System.Drawing.Size(281, 55);
            this.btnPatientManagement.TabIndex = 0;
            this.btnPatientManagement.Tag = "    Patient Management";
            this.btnPatientManagement.Text = "    Patient Management";
            this.btnPatientManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPatientManagement.Click += new System.EventHandler(this.btnPatientManagement_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.lblUsername.Location = new System.Drawing.Point(1127, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.label2.Location = new System.Drawing.Point(344, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // MainHeader
            // 
            this.MainHeader.BackColor = System.Drawing.Color.LightBlue;
            this.MainHeader.Controls.Add(this.btnToggle);
            this.MainHeader.Controls.Add(this.label2);
            this.MainHeader.Controls.Add(this.btnViewUserMenu);
            this.MainHeader.Controls.Add(this.lblUsername);
            this.MainHeader.Controls.Add(this.pbUserProfile);
            this.MainHeader.Controls.Add(this.pictureBox1);
            this.MainHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainHeader.Location = new System.Drawing.Point(0, 0);
            this.MainHeader.Name = "MainHeader";
            this.MainHeader.Size = new System.Drawing.Size(1313, 70);
            this.MainHeader.TabIndex = 0;
            // 
            // btnToggle
            // 
            this.btnToggle.Image = global::HospitalManagementSystem.Properties.Resources.icons8_menu_64;
            this.btnToggle.Location = new System.Drawing.Point(14, 17);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(58, 41);
            this.btnToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnToggle.TabIndex = 3;
            this.btnToggle.TabStop = false;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnViewUserMenu
            // 
            this.btnViewUserMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewUserMenu.ContextMenuStrip = this.systemUserMenu;
            this.btnViewUserMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUserMenu.Image = global::HospitalManagementSystem.Properties.Resources.icons8_sort_down_64;
            this.btnViewUserMenu.Location = new System.Drawing.Point(1266, 25);
            this.btnViewUserMenu.Name = "btnViewUserMenu";
            this.btnViewUserMenu.Size = new System.Drawing.Size(36, 36);
            this.btnViewUserMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnViewUserMenu.TabIndex = 2;
            this.btnViewUserMenu.TabStop = false;
            this.btnViewUserMenu.Click += new System.EventHandler(this.btnViewUserMenu_Click);
            // 
            // pbUserProfile
            // 
            this.pbUserProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUserProfile.BaseColor = System.Drawing.Color.White;
            this.pbUserProfile.Image = global::HospitalManagementSystem.Properties.Resources.icons8_user_profile_64;
            this.pbUserProfile.Location = new System.Drawing.Point(1064, 5);
            this.pbUserProfile.Name = "pbUserProfile";
            this.pbUserProfile.Size = new System.Drawing.Size(60, 60);
            this.pbUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserProfile.TabIndex = 1;
            this.pbUserProfile.TabStop = false;
            this.pbUserProfile.UseTransfarantBackground = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.SmallTransperntlogo;
            this.pictureBox1.Location = new System.Drawing.Point(79, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainFooter
            // 
            this.MainFooter.BackColor = System.Drawing.Color.LightBlue;
            this.MainFooter.Controls.Add(this.lblDateTime);
            this.MainFooter.Controls.Add(this.lblCopyright);
            this.MainFooter.Controls.Add(this.lblAppNameVersion);
            this.MainFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainFooter.Location = new System.Drawing.Point(281, 844);
            this.MainFooter.Name = "MainFooter";
            this.MainFooter.Size = new System.Drawing.Size(1032, 40);
            this.MainFooter.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.lblDateTime.Location = new System.Drawing.Point(723, 10);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(195, 21);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "\"yyyy-MM-dd HH:mm:ss\"";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.lblCopyright.Location = new System.Drawing.Point(407, 10);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(202, 23);
            this.lblCopyright.TabIndex = 4;
            this.lblCopyright.Text = "© 2025 Fatimah Daifallah";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppNameVersion
            // 
            this.lblAppNameVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAppNameVersion.AutoSize = true;
            this.lblAppNameVersion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppNameVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.lblAppNameVersion.Location = new System.Drawing.Point(3, 10);
            this.lblAppNameVersion.Name = "lblAppNameVersion";
            this.lblAppNameVersion.Size = new System.Drawing.Size(286, 23);
            this.lblAppNameVersion.TabIndex = 3;
            this.lblAppNameVersion.Text = "Hospital Management System v1.0.0";
            this.lblAppNameVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // systemTimer
            // 
            this.systemTimer.Interval = 1000;
            this.systemTimer.Tick += new System.EventHandler(this.systemTimer_Tick);
            // 
            // panelMainContent
            // 
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(281, 70);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Size = new System.Drawing.Size(1032, 774);
            this.panelMainContent.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 884);
            this.Controls.Add(this.panelMainContent);
            this.Controls.Add(this.MainFooter);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.MainHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.systemUserMenu.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.MainHeader.ResumeLayout(false);
            this.MainHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewUserMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainFooter.ResumeLayout(false);
            this.MainFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip systemUserMenu;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panelSidebar;
        private Guna.UI.WinForms.GunaButton btnPatientManagement;
        private Guna.UI.WinForms.GunaButton btnSttaffManagement;
        private Guna.UI.WinForms.GunaButton btnSettings;
        private Guna.UI.WinForms.GunaButton btnReports;
        private Guna.UI.WinForms.GunaButton btnAuditsManagement;
        private Guna.UI.WinForms.GunaButton btnUsersManagement;
        private Guna.UI.WinForms.GunaButton btnLabTestsManagement;
        private Guna.UI.WinForms.GunaButton btnMedicalRecordsManagement;
        private Guna.UI.WinForms.GunaButton btnAppointmentsManagement;
        private Guna.UI.WinForms.GunaButton btnDoctorsManagement;
        private Guna.UI.WinForms.GunaButton btnInvoicesManagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox pbUserProfile;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox btnViewUserMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnToggle;
        private System.Windows.Forms.Panel MainHeader;
        private System.Windows.Forms.Panel MainFooter;
        private System.Windows.Forms.Label lblAppNameVersion;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Timer systemTimer;
        private Guna.UI.WinForms.GunaButton btnDashboard;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.ToolStripMenuItem viewUserInfoToolStripMenuItem1;
    }
}