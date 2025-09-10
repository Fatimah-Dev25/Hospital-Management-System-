namespace HospitalManagementSystem.Forms.Users
{
    partial class frmAddUpdateUser
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbIsUserActive = new System.Windows.Forms.RadioButton();
            this.cbUserRoles = new System.Windows.Forms.ComboBox();
            this.btnViewConfirmPassword = new Guna.UI.WinForms.GunaImageButton();
            this.btnViewPassword = new Guna.UI.WinForms.GunaImageButton();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.tcUserSettings = new System.Windows.Forms.TabControl();
            this.tpSelectPerson = new System.Windows.Forms.TabPage();
            this.personCardWithFilter1 = new HospitalManagementSystem.Forms.People.usercontrols.PersonCardWithFilter();
            this.tpUserInfo = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcUserSettings.SuspendLayout();
            this.tpSelectPerson.SuspendLayout();
            this.tpUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(104, 27);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(73, 31);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "User ID:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserID.Location = new System.Drawing.Point(90, 109);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(33, 20);
            this.lblUserID.TabIndex = 3;
            this.lblUserID.Text = "[??]";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.rbIsUserActive);
            this.panel1.Controls.Add(this.cbUserRoles);
            this.panel1.Controls.Add(this.btnViewConfirmPassword);
            this.panel1.Controls.Add(this.btnViewPassword);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(35, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 407);
            this.panel1.TabIndex = 4;
            // 
            // rbIsUserActive
            // 
            this.rbIsUserActive.AutoSize = true;
            this.rbIsUserActive.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIsUserActive.ForeColor = System.Drawing.Color.Brown;
            this.rbIsUserActive.Location = new System.Drawing.Point(153, 266);
            this.rbIsUserActive.Name = "rbIsUserActive";
            this.rbIsUserActive.Size = new System.Drawing.Size(86, 21);
            this.rbIsUserActive.TabIndex = 16;
            this.rbIsUserActive.TabStop = true;
            this.rbIsUserActive.Text = "is Active?";
            this.rbIsUserActive.UseVisualStyleBackColor = true;
            // 
            // cbUserRoles
            // 
            this.cbUserRoles.FormattingEnabled = true;
            this.cbUserRoles.Location = new System.Drawing.Point(153, 209);
            this.cbUserRoles.Name = "cbUserRoles";
            this.cbUserRoles.Size = new System.Drawing.Size(249, 24);
            this.cbUserRoles.TabIndex = 15;
            // 
            // btnViewConfirmPassword
            // 
            this.btnViewConfirmPassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewConfirmPassword.Image = global::HospitalManagementSystem.Properties.Resources.eye;
            this.btnViewConfirmPassword.ImageSize = new System.Drawing.Size(20, 20);
            this.btnViewConfirmPassword.Location = new System.Drawing.Point(408, 149);
            this.btnViewConfirmPassword.Name = "btnViewConfirmPassword";
            this.btnViewConfirmPassword.OnHoverImage = null;
            this.btnViewConfirmPassword.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnViewConfirmPassword.Size = new System.Drawing.Size(26, 26);
            this.btnViewConfirmPassword.TabIndex = 14;
            this.btnViewConfirmPassword.Click += new System.EventHandler(this.btnViewConfirmPassword_Click);
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnViewPassword.Image = global::HospitalManagementSystem.Properties.Resources.eye;
            this.btnViewPassword.ImageSize = new System.Drawing.Size(20, 20);
            this.btnViewPassword.Location = new System.Drawing.Point(408, 94);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.OnHoverImage = null;
            this.btnViewPassword.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnViewPassword.Size = new System.Drawing.Size(26, 26);
            this.btnViewPassword.TabIndex = 13;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(153, 152);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(249, 22);
            this.txtConfirmPassword.TabIndex = 12;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(153, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 22);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(92, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Active:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(104, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(70, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(153, 38);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 22);
            this.txtUsername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(65, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.management;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnSave.BorderSize = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btnSave.Image = global::HospitalManagementSystem.Properties.Resources.save;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(603, 686);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.Snow;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.Gray;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.LightGray;
            this.btnSave.Radius = 8;
            this.btnSave.Size = new System.Drawing.Size(160, 42);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcUserSettings
            // 
            this.tcUserSettings.Controls.Add(this.tpSelectPerson);
            this.tcUserSettings.Controls.Add(this.tpUserInfo);
            this.tcUserSettings.Location = new System.Drawing.Point(14, 144);
            this.tcUserSettings.Name = "tcUserSettings";
            this.tcUserSettings.SelectedIndex = 0;
            this.tcUserSettings.Size = new System.Drawing.Size(753, 536);
            this.tcUserSettings.TabIndex = 18;
            // 
            // tpSelectPerson
            // 
            this.tpSelectPerson.Controls.Add(this.personCardWithFilter1);
            this.tpSelectPerson.Location = new System.Drawing.Point(4, 25);
            this.tpSelectPerson.Name = "tpSelectPerson";
            this.tpSelectPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectPerson.Size = new System.Drawing.Size(745, 507);
            this.tpSelectPerson.TabIndex = 0;
            this.tpSelectPerson.Text = "Select Person";
            this.tpSelectPerson.UseVisualStyleBackColor = true;
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personCardWithFilter1.FilterEnabled = true;
            this.personCardWithFilter1.Location = new System.Drawing.Point(3, 3);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.ShowAddPerson = true;
            this.personCardWithFilter1.Size = new System.Drawing.Size(738, 501);
            this.personCardWithFilter1.TabIndex = 0;
            this.personCardWithFilter1.onPersonSelected += new System.Action<int>(this.personCardWithFilter1_onPersonSelected);
            // 
            // tpUserInfo
            // 
            this.tpUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(244)))));
            this.tpUserInfo.Controls.Add(this.panel1);
            this.tpUserInfo.Location = new System.Drawing.Point(4, 25);
            this.tpUserInfo.Name = "tpUserInfo";
            this.tpUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserInfo.Size = new System.Drawing.Size(745, 507);
            this.tpUserInfo.TabIndex = 1;
            this.tpUserInfo.Text = "User Info";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 745);
            this.Controls.Add(this.tcUserSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateUser";
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcUserSettings.ResumeLayout(false);
            this.tpSelectPerson.ResumeLayout(false);
            this.tpUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaImageButton btnViewPassword;
        private Guna.UI.WinForms.GunaImageButton btnViewConfirmPassword;
        private System.Windows.Forms.RadioButton rbIsUserActive;
        private System.Windows.Forms.ComboBox cbUserRoles;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.TabControl tcUserSettings;
        private System.Windows.Forms.TabPage tpSelectPerson;
        private System.Windows.Forms.TabPage tpUserInfo;
        private People.usercontrols.PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}