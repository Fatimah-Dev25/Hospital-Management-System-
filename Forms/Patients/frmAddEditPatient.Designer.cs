namespace HospitalManagementSystem.Forms.Patients
{
    partial class frmAddEditPatient
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.tcPatientInfo = new System.Windows.Forms.TabControl();
            this.tpSelectPerson = new System.Windows.Forms.TabPage();
            this.btnNextToDetails = new Guna.UI.WinForms.GunaButton();
            this.personCardWithFilter1 = new HospitalManagementSystem.Forms.People.usercontrols.PersonCardWithFilter();
            this.tpAddPatient = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbBloodType = new System.Windows.Forms.ComboBox();
            this.cbAdmissionStatus = new System.Windows.Forms.ComboBox();
            this.txtChronicDiseases = new System.Windows.Forms.TextBox();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblFileNumber = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tcPatientInfo.SuspendLayout();
            this.tpSelectPerson.SuspendLayout();
            this.tpAddPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tcPatientInfo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(181, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 749);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BaseColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.BorderSize = 1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Image = global::HospitalManagementSystem.Properties.Resources.close__1_;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(407, 683);
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
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Enabled = false;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::HospitalManagementSystem.Properties.Resources.icons8_save_32__1_;
            this.btnSave.ImageSize = new System.Drawing.Size(29, 29);
            this.btnSave.Location = new System.Drawing.Point(578, 683);
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
            // tcPatientInfo
            // 
            this.tcPatientInfo.Controls.Add(this.tpSelectPerson);
            this.tcPatientInfo.Controls.Add(this.tpAddPatient);
            this.tcPatientInfo.Location = new System.Drawing.Point(7, 77);
            this.tcPatientInfo.Name = "tcPatientInfo";
            this.tcPatientInfo.SelectedIndex = 0;
            this.tcPatientInfo.Size = new System.Drawing.Size(756, 600);
            this.tcPatientInfo.TabIndex = 1;
            // 
            // tpSelectPerson
            // 
            this.tpSelectPerson.Controls.Add(this.btnNextToDetails);
            this.tpSelectPerson.Controls.Add(this.personCardWithFilter1);
            this.tpSelectPerson.Location = new System.Drawing.Point(4, 25);
            this.tpSelectPerson.Name = "tpSelectPerson";
            this.tpSelectPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectPerson.Size = new System.Drawing.Size(748, 571);
            this.tpSelectPerson.TabIndex = 0;
            this.tpSelectPerson.Text = "Select Person";
            this.tpSelectPerson.UseVisualStyleBackColor = true;
            // 
            // btnNextToDetails
            // 
            this.btnNextToDetails.AnimationHoverSpeed = 0.07F;
            this.btnNextToDetails.AnimationSpeed = 0.03F;
            this.btnNextToDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnNextToDetails.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnNextToDetails.BorderColor = System.Drawing.Color.Black;
            this.btnNextToDetails.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextToDetails.FocusedColor = System.Drawing.Color.Empty;
            this.btnNextToDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextToDetails.ForeColor = System.Drawing.Color.White;
            this.btnNextToDetails.Image = global::HospitalManagementSystem.Properties.Resources.right_chevron;
            this.btnNextToDetails.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextToDetails.Location = new System.Drawing.Point(573, 518);
            this.btnNextToDetails.Name = "btnNextToDetails";
            this.btnNextToDetails.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnNextToDetails.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNextToDetails.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNextToDetails.OnHoverImage = null;
            this.btnNextToDetails.OnPressedColor = System.Drawing.Color.Black;
            this.btnNextToDetails.Radius = 8;
            this.btnNextToDetails.Size = new System.Drawing.Size(160, 42);
            this.btnNextToDetails.TabIndex = 1;
            this.btnNextToDetails.Text = "Next";
            this.btnNextToDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNextToDetails.Click += new System.EventHandler(this.btnNextToDetails_Click_1);
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personCardWithFilter1.FilterEnabled = true;
            this.personCardWithFilter1.Location = new System.Drawing.Point(4, 7);
            this.personCardWithFilter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.ShowAddPerson = true;
            this.personCardWithFilter1.Size = new System.Drawing.Size(736, 499);
            this.personCardWithFilter1.TabIndex = 0;
            this.personCardWithFilter1.onPersonSelected += new System.Action<int>(this.personCardWithFilter1_onPersonSelected);
            // 
            // tpAddPatient
            // 
            this.tpAddPatient.Controls.Add(this.pictureBox6);
            this.tpAddPatient.Controls.Add(this.pictureBox5);
            this.tpAddPatient.Controls.Add(this.pictureBox4);
            this.tpAddPatient.Controls.Add(this.pictureBox3);
            this.tpAddPatient.Controls.Add(this.pictureBox2);
            this.tpAddPatient.Controls.Add(this.pictureBox1);
            this.tpAddPatient.Controls.Add(this.cbBloodType);
            this.tpAddPatient.Controls.Add(this.cbAdmissionStatus);
            this.tpAddPatient.Controls.Add(this.txtChronicDiseases);
            this.tpAddPatient.Controls.Add(this.txtAllergies);
            this.tpAddPatient.Controls.Add(this.lblFileNumber);
            this.tpAddPatient.Controls.Add(this.lblPatientID);
            this.tpAddPatient.Controls.Add(this.label6);
            this.tpAddPatient.Controls.Add(this.label5);
            this.tpAddPatient.Controls.Add(this.label4);
            this.tpAddPatient.Controls.Add(this.label3);
            this.tpAddPatient.Controls.Add(this.label2);
            this.tpAddPatient.Controls.Add(this.label1);
            this.tpAddPatient.Location = new System.Drawing.Point(4, 25);
            this.tpAddPatient.Name = "tpAddPatient";
            this.tpAddPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddPatient.Size = new System.Drawing.Size(748, 571);
            this.tpAddPatient.TabIndex = 1;
            this.tpAddPatient.Text = "Add Patient";
            this.tpAddPatient.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::HospitalManagementSystem.Properties.Resources.blood_type__1_;
            this.pictureBox6.Location = new System.Drawing.Point(172, 412);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::HospitalManagementSystem.Properties.Resources.loading__1_;
            this.pictureBox5.Location = new System.Drawing.Point(172, 353);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HospitalManagementSystem.Properties.Resources.heart_disease__1_;
            this.pictureBox4.Location = new System.Drawing.Point(172, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HospitalManagementSystem.Properties.Resources.treatment__1_;
            this.pictureBox3.Location = new System.Drawing.Point(172, 157);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HospitalManagementSystem.Properties.Resources.google_docs__1_;
            this.pictureBox2.Location = new System.Drawing.Point(172, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.icons8_hash_24;
            this.pictureBox1.Location = new System.Drawing.Point(172, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cbBloodType
            // 
            this.cbBloodType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBloodType.FormattingEnabled = true;
            this.cbBloodType.Location = new System.Drawing.Point(207, 412);
            this.cbBloodType.Name = "cbBloodType";
            this.cbBloodType.Size = new System.Drawing.Size(185, 28);
            this.cbBloodType.TabIndex = 11;
            // 
            // cbAdmissionStatus
            // 
            this.cbAdmissionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmissionStatus.FormattingEnabled = true;
            this.cbAdmissionStatus.Items.AddRange(new object[] {
            "Admitted",
            "Outpatient",
            "Discharged"});
            this.cbAdmissionStatus.Location = new System.Drawing.Point(207, 353);
            this.cbAdmissionStatus.Name = "cbAdmissionStatus";
            this.cbAdmissionStatus.Size = new System.Drawing.Size(185, 28);
            this.cbAdmissionStatus.TabIndex = 10;
            // 
            // txtChronicDiseases
            // 
            this.txtChronicDiseases.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChronicDiseases.Location = new System.Drawing.Point(207, 234);
            this.txtChronicDiseases.Multiline = true;
            this.txtChronicDiseases.Name = "txtChronicDiseases";
            this.txtChronicDiseases.Size = new System.Drawing.Size(489, 102);
            this.txtChronicDiseases.TabIndex = 9;
            // 
            // txtAllergies
            // 
            this.txtAllergies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllergies.Location = new System.Drawing.Point(207, 157);
            this.txtAllergies.Multiline = true;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(489, 55);
            this.txtAllergies.TabIndex = 8;
            // 
            // lblFileNumber
            // 
            this.lblFileNumber.AutoSize = true;
            this.lblFileNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblFileNumber.Location = new System.Drawing.Point(203, 100);
            this.lblFileNumber.Name = "lblFileNumber";
            this.lblFileNumber.Size = new System.Drawing.Size(50, 23);
            this.lblFileNumber.TabIndex = 7;
            this.lblFileNumber.Text = "?????";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPatientID.Location = new System.Drawing.Point(203, 43);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(52, 23);
            this.lblPatientID.TabIndex = 6;
            this.lblPatientID.Text = "[###]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(61, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Blood Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(16, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Admission Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(17, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chronic Diseases:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(81, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Allergies:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(52, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(767, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::HospitalManagementSystem.Properties.Resources.AdobeStock_52723121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 758);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddEditPatient";
            this.Load += new System.EventHandler(this.frmAddEditPatient_Load);
            this.panel1.ResumeLayout(false);
            this.tcPatientInfo.ResumeLayout(false);
            this.tpSelectPerson.ResumeLayout(false);
            this.tpAddPatient.ResumeLayout(false);
            this.tpAddPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcPatientInfo;
        private System.Windows.Forms.TabPage tpSelectPerson;
        private People.usercontrols.PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.TabPage tpAddPatient;
        private Guna.UI.WinForms.GunaButton btnNextToDetails;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBloodType;
        private System.Windows.Forms.ComboBox cbAdmissionStatus;
        private System.Windows.Forms.TextBox txtChronicDiseases;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblFileNumber;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}