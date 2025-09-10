namespace HospitalManagementSystem.Forms.Doctors
{
    partial class frmAddEditDoctor
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
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.tcDotorDetail = new System.Windows.Forms.TabControl();
            this.tpSelectPeson = new System.Windows.Forms.TabPage();
            this.btnNextToDetail = new Guna.UI.WinForms.GunaImageButton();
            this.personCardWithFilter1 = new HospitalManagementSystem.Forms.People.usercontrols.PersonCardWithFilter();
            this.tpAddDoctor = new System.Windows.Forms.TabPage();
            this.cbDepartmentsList = new System.Windows.Forms.ComboBox();
            this.dtDateHired = new System.Windows.Forms.DateTimePicker();
            this.txtExperienceYears = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gunaGradient2Panel1.SuspendLayout();
            this.tcDotorDetail.SuspendLayout();
            this.tpSelectPeson.SuspendLayout();
            this.tpAddDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaGradient2Panel1.Controls.Add(this.btnClose);
            this.gunaGradient2Panel1.Controls.Add(this.btnSave);
            this.gunaGradient2Panel1.Controls.Add(this.tcDotorDetail);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.White;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(359, 22);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(766, 662);
            this.gunaGradient2Panel1.TabIndex = 0;
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.BorderSize = 1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(234, 603);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Radius = 8;
            this.btnClose.Size = new System.Drawing.Size(160, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.BlueViolet;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(404, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 8;
            this.btnSave.Size = new System.Drawing.Size(160, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tcDotorDetail
            // 
            this.tcDotorDetail.Controls.Add(this.tpSelectPeson);
            this.tcDotorDetail.Controls.Add(this.tpAddDoctor);
            this.tcDotorDetail.Location = new System.Drawing.Point(3, 3);
            this.tcDotorDetail.Name = "tcDotorDetail";
            this.tcDotorDetail.SelectedIndex = 0;
            this.tcDotorDetail.Size = new System.Drawing.Size(759, 589);
            this.tcDotorDetail.TabIndex = 0;
            // 
            // tpSelectPeson
            // 
            this.tpSelectPeson.Controls.Add(this.btnNextToDetail);
            this.tpSelectPeson.Controls.Add(this.personCardWithFilter1);
            this.tpSelectPeson.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSelectPeson.Location = new System.Drawing.Point(4, 25);
            this.tpSelectPeson.Name = "tpSelectPeson";
            this.tpSelectPeson.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectPeson.Size = new System.Drawing.Size(751, 560);
            this.tpSelectPeson.TabIndex = 0;
            this.tpSelectPeson.Text = "Select Person";
            this.tpSelectPeson.UseVisualStyleBackColor = true;
            // 
            // btnNextToDetail
            // 
            this.btnNextToDetail.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextToDetail.Image = global::HospitalManagementSystem.Properties.Resources.next_button;
            this.btnNextToDetail.ImageSize = new System.Drawing.Size(44, 44);
            this.btnNextToDetail.Location = new System.Drawing.Point(645, 504);
            this.btnNextToDetail.Name = "btnNextToDetail";
            this.btnNextToDetail.OnHoverImage = null;
            this.btnNextToDetail.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnNextToDetail.Size = new System.Drawing.Size(100, 40);
            this.btnNextToDetail.TabIndex = 1;
            this.btnNextToDetail.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personCardWithFilter1.FilterEnabled = true;
            this.personCardWithFilter1.Location = new System.Drawing.Point(7, 7);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.ShowAddPerson = true;
            this.personCardWithFilter1.Size = new System.Drawing.Size(738, 475);
            this.personCardWithFilter1.TabIndex = 0;
            this.personCardWithFilter1.onPersonSelected += new System.Action<int>(this.personCardWithFilter1_onPersonSelected);
            // 
            // tpAddDoctor
            // 
            this.tpAddDoctor.Controls.Add(this.cbDepartmentsList);
            this.tpAddDoctor.Controls.Add(this.dtDateHired);
            this.tpAddDoctor.Controls.Add(this.txtExperienceYears);
            this.tpAddDoctor.Controls.Add(this.txtSpecialization);
            this.tpAddDoctor.Controls.Add(this.pictureBox5);
            this.tpAddDoctor.Controls.Add(this.pictureBox4);
            this.tpAddDoctor.Controls.Add(this.pictureBox3);
            this.tpAddDoctor.Controls.Add(this.pictureBox2);
            this.tpAddDoctor.Controls.Add(this.pictureBox1);
            this.tpAddDoctor.Controls.Add(this.label6);
            this.tpAddDoctor.Controls.Add(this.label5);
            this.tpAddDoctor.Controls.Add(this.label4);
            this.tpAddDoctor.Controls.Add(this.label3);
            this.tpAddDoctor.Controls.Add(this.label2);
            this.tpAddDoctor.Controls.Add(this.lblDoctorID);
            this.tpAddDoctor.Controls.Add(this.label1);
            this.tpAddDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAddDoctor.Location = new System.Drawing.Point(4, 25);
            this.tpAddDoctor.Name = "tpAddDoctor";
            this.tpAddDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddDoctor.Size = new System.Drawing.Size(751, 560);
            this.tpAddDoctor.TabIndex = 1;
            this.tpAddDoctor.Text = "Add Doctor";
            this.tpAddDoctor.UseVisualStyleBackColor = true;
            // 
            // cbDepartmentsList
            // 
            this.cbDepartmentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartmentsList.FormattingEnabled = true;
            this.cbDepartmentsList.Location = new System.Drawing.Point(237, 368);
            this.cbDepartmentsList.Name = "cbDepartmentsList";
            this.cbDepartmentsList.Size = new System.Drawing.Size(232, 25);
            this.cbDepartmentsList.TabIndex = 15;
            // 
            // dtDateHired
            // 
            this.dtDateHired.Font = new System.Drawing.Font("Segoe UI Semibold", 8.8F, System.Drawing.FontStyle.Bold);
            this.dtDateHired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateHired.Location = new System.Drawing.Point(237, 284);
            this.dtDateHired.Name = "dtDateHired";
            this.dtDateHired.Size = new System.Drawing.Size(182, 27);
            this.dtDateHired.TabIndex = 14;
            // 
            // txtExperienceYears
            // 
            this.txtExperienceYears.Location = new System.Drawing.Point(237, 204);
            this.txtExperienceYears.Name = "txtExperienceYears";
            this.txtExperienceYears.Size = new System.Drawing.Size(182, 25);
            this.txtExperienceYears.TabIndex = 13;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(237, 125);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(460, 25);
            this.txtSpecialization.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HospitalManagementSystem.Properties.Resources.networking;
            this.pictureBox5.Location = new System.Drawing.Point(193, 367);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HospitalManagementSystem.Properties.Resources.calendar;
            this.pictureBox4.Location = new System.Drawing.Point(193, 286);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HospitalManagementSystem.Properties.Resources.best_customer_experience;
            this.pictureBox3.Location = new System.Drawing.Point(193, 205);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HospitalManagementSystem.Properties.Resources.vacancy;
            this.pictureBox2.Location = new System.Drawing.Point(193, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.number;
            this.pictureBox1.Location = new System.Drawing.Point(164, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(70, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Department: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(79, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Hired: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(35, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Experience Years: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(58, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Specialization: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(751, 2);
            this.label2.TabIndex = 2;
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.lblDoctorID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDoctorID.Location = new System.Drawing.Point(197, 43);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(52, 23);
            this.lblDoctorID.TabIndex = 1;
            this.lblDoctorID.Text = "[###]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor ID: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.medical_background_cjge7e89adg6ub8x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 707);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEditDoctor";
            this.Load += new System.EventHandler(this.frmAddEditDoctor_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.tcDotorDetail.ResumeLayout(false);
            this.tpSelectPeson.ResumeLayout(false);
            this.tpAddDoctor.ResumeLayout(false);
            this.tpAddDoctor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.TabControl tcDotorDetail;
        private System.Windows.Forms.TabPage tpSelectPeson;
        private People.usercontrols.PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.TabPage tpAddDoctor;
        private Guna.UI.WinForms.GunaImageButton btnNextToDetail;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbDepartmentsList;
        private System.Windows.Forms.DateTimePicker dtDateHired;
        private System.Windows.Forms.TextBox txtExperienceYears;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}