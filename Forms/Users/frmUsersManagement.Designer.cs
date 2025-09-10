namespace HospitalManagementSystem.Forms.Users
{
    partial class frmUsersManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.usersMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRolesManage = new Guna.UI.WinForms.GunaButton();
            this.btnAddUser = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.usersMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.ContextMenuStrip = this.usersMenu;
            this.dgvAllUsers.Location = new System.Drawing.Point(12, 117);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.RowHeadersVisible = false;
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.Height = 24;
            this.dgvAllUsers.Size = new System.Drawing.Size(1194, 615);
            this.dgvAllUsers.TabIndex = 2;
            this.dgvAllUsers.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllUsers_CellMouseDown);
            // 
            // usersMenu
            // 
            this.usersMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(244)))));
            this.usersMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usersMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateUserToolStripMenuItem,
            this.showUserToolStripMenuItem1,
            this.activeToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.usersMenu.Name = "usersMenu";
            this.usersMenu.Size = new System.Drawing.Size(215, 136);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.updateUserToolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.update;
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // showUserToolStripMenuItem1
            // 
            this.showUserToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.showUserToolStripMenuItem1.Image = global::HospitalManagementSystem.Properties.Resources.page;
            this.showUserToolStripMenuItem1.Name = "showUserToolStripMenuItem1";
            this.showUserToolStripMenuItem1.Size = new System.Drawing.Size(214, 26);
            this.showUserToolStripMenuItem1.Text = "Show User Detail";
            this.showUserToolStripMenuItem1.Click += new System.EventHandler(this.showUserToolStripMenuItem1_Click);
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.activeToolStripMenuItem.Text = "Active";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.changePasswordToolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.reset_password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::HospitalManagementSystem.Properties.Resources.user__2_;
            this.pictureBox2.Location = new System.Drawing.Point(1212, 316);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 287);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.team;
            this.pictureBox1.Location = new System.Drawing.Point(22, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnRolesManage
            // 
            this.btnRolesManage.AnimationHoverSpeed = 0.07F;
            this.btnRolesManage.AnimationSpeed = 0.03F;
            this.btnRolesManage.BackColor = System.Drawing.Color.Transparent;
            this.btnRolesManage.BaseColor = System.Drawing.Color.Transparent;
            this.btnRolesManage.BorderColor = System.Drawing.Color.Black;
            this.btnRolesManage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRolesManage.FocusedColor = System.Drawing.Color.Empty;
            this.btnRolesManage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnRolesManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnRolesManage.Image = global::HospitalManagementSystem.Properties.Resources.icons8_settings_32;
            this.btnRolesManage.ImageSize = new System.Drawing.Size(28, 28);
            this.btnRolesManage.Location = new System.Drawing.Point(1233, 198);
            this.btnRolesManage.Name = "btnRolesManage";
            this.btnRolesManage.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnRolesManage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRolesManage.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRolesManage.OnHoverImage = null;
            this.btnRolesManage.OnPressedColor = System.Drawing.Color.LightGray;
            this.btnRolesManage.Size = new System.Drawing.Size(226, 38);
            this.btnRolesManage.TabIndex = 4;
            this.btnRolesManage.Text = "User Roles Manage";
            this.btnRolesManage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnRolesManage.Click += new System.EventHandler(this.btnRolesManage_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AnimationHoverSpeed = 0.07F;
            this.btnAddUser.AnimationSpeed = 0.03F;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnAddUser.Image = global::HospitalManagementSystem.Properties.Resources.icons8_add_281;
            this.btnAddUser.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAddUser.Location = new System.Drawing.Point(1233, 139);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnAddUser.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverImage = null;
            this.btnAddUser.OnPressedColor = System.Drawing.Color.Silver;
            this.btnAddUser.Size = new System.Drawing.Size(141, 38);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1556, 744);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRolesManage);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.dgvAllUsers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.usersMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private Guna.UI.WinForms.GunaButton btnAddUser;
        private System.Windows.Forms.ContextMenuStrip usersMenu;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private Guna.UI.WinForms.GunaButton btnRolesManage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem showUserToolStripMenuItem1;
    }
}