namespace HospitalManagementSystem.Forms.Prescriptions
{
    partial class frmIssuePrescription
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
            this.lblPatientName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrugUpdate = new Guna.UI.WinForms.GunaImageButton();
            this.btnAddDrug = new Guna.UI.WinForms.GunaImageButton();
            this.cbDuration = new System.Windows.Forms.ComboBox();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.cbDosage = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDrugPrice = new System.Windows.Forms.TextBox();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDrugsList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolUpdateDrug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRemoveDrug = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.llPrintPrescription = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblPatientName.Location = new System.Drawing.Point(145, 113);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(45, 21);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "?????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(407, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor Name:";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.Location = new System.Drawing.Point(508, 113);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(45, 21);
            this.lblDoctorName.TabIndex = 3;
            this.lblDoctorName.Text = "?????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(407, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(450, 73);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(80, 21);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "??/??/????";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDrugUpdate);
            this.groupBox1.Controls.Add(this.btnAddDrug);
            this.groupBox1.Controls.Add(this.cbDuration);
            this.groupBox1.Controls.Add(this.cbFrequency);
            this.groupBox1.Controls.Add(this.cbDosage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDrugPrice);
            this.groupBox1.Controls.Add(this.txtDrugName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 176);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drug Detail";
            // 
            // btnDrugUpdate
            // 
            this.btnDrugUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrugUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDrugUpdate.Image = global::HospitalManagementSystem.Properties.Resources.save;
            this.btnDrugUpdate.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDrugUpdate.Location = new System.Drawing.Point(629, 125);
            this.btnDrugUpdate.Name = "btnDrugUpdate";
            this.btnDrugUpdate.OnHoverImage = null;
            this.btnDrugUpdate.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnDrugUpdate.Size = new System.Drawing.Size(45, 45);
            this.btnDrugUpdate.TabIndex = 21;
            this.btnDrugUpdate.Visible = false;
            this.btnDrugUpdate.Click += new System.EventHandler(this.btnDrugUpdate_Click);
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDrug.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDrug.Image = global::HospitalManagementSystem.Properties.Resources.add__1_;
            this.btnAddDrug.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddDrug.Location = new System.Drawing.Point(629, 125);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.OnHoverImage = null;
            this.btnAddDrug.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddDrug.Size = new System.Drawing.Size(45, 45);
            this.btnAddDrug.TabIndex = 8;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // cbDuration
            // 
            this.cbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDuration.FormattingEnabled = true;
            this.cbDuration.Items.AddRange(new object[] {
            "None",
            "1 day",
            "3 days",
            "5 days",
            "7 days",
            "10 days",
            "14 days",
            "21 days",
            "1 month",
            "3 months",
            "Until finished",
            "As prescribed"});
            this.cbDuration.Location = new System.Drawing.Point(448, 74);
            this.cbDuration.Name = "cbDuration";
            this.cbDuration.Size = new System.Drawing.Size(194, 28);
            this.cbDuration.TabIndex = 20;
            // 
            // cbFrequency
            // 
            this.cbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Items.AddRange(new object[] {
            "None",
            "Once a day",
            "Twice a day",
            "Three times a day",
            "Four times a day",
            "Every 6 hours",
            "Every 8 hours",
            "Every 12 hours",
            "Once a week",
            "Twice a week",
            "As needed",
            "Before meals",
            "After meals"});
            this.cbFrequency.Location = new System.Drawing.Point(81, 74);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(218, 28);
            this.cbFrequency.TabIndex = 19;
            // 
            // cbDosage
            // 
            this.cbDosage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDosage.FormattingEnabled = true;
            this.cbDosage.Items.AddRange(new object[] {
            "None",
            "5 mg",
            "10 mg",
            "25 mg",
            "50 mg",
            "100 mg",
            "250 mg",
            "500 mg",
            "1 g",
            "2 g",
            "5 ml",
            "10 ml",
            "1 tablet",
            "2 tablets",
            "1 capsule",
            "Half tablet",
            "1 drop",
            "1 puff",
            "1 suppository"});
            this.cbDosage.Location = new System.Drawing.Point(448, 34);
            this.cbDosage.Name = "cbDosage";
            this.cbDosage.Size = new System.Drawing.Size(194, 28);
            this.cbDosage.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "aed.";
            // 
            // txtDrugPrice
            // 
            this.txtDrugPrice.Location = new System.Drawing.Point(81, 112);
            this.txtDrugPrice.Name = "txtDrugPrice";
            this.txtDrugPrice.Size = new System.Drawing.Size(81, 27);
            this.txtDrugPrice.TabIndex = 16;
            this.txtDrugPrice.TextChanged += new System.EventHandler(this.txtDrugPrice_TextChanged);
            this.txtDrugPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDrugPrice_KeyPress);
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(81, 34);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(218, 27);
            this.txtDrugName.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(34, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(379, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Frequency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(389, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dosage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Drug:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.systemLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDrugsList
            // 
            this.dgvDrugsList.AllowUserToAddRows = false;
            this.dgvDrugsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrugsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrugsList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDrugsList.Location = new System.Drawing.Point(12, 352);
            this.dgvDrugsList.Name = "dgvDrugsList";
            this.dgvDrugsList.RowHeadersVisible = false;
            this.dgvDrugsList.RowHeadersWidth = 51;
            this.dgvDrugsList.RowTemplate.Height = 24;
            this.dgvDrugsList.Size = new System.Drawing.Size(675, 269);
            this.dgvDrugsList.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUpdateDrug,
            this.toolRemoveDrug});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // toolUpdateDrug
            // 
            this.toolUpdateDrug.Name = "toolUpdateDrug";
            this.toolUpdateDrug.Size = new System.Drawing.Size(132, 24);
            this.toolUpdateDrug.Text = "Update";
            this.toolUpdateDrug.Click += new System.EventHandler(this.toolUpdateDrug_Click);
            // 
            // toolRemoveDrug
            // 
            this.toolRemoveDrug.Name = "toolRemoveDrug";
            this.toolRemoveDrug.Size = new System.Drawing.Size(132, 24);
            this.toolRemoveDrug.Text = "Remove";
            this.toolRemoveDrug.Click += new System.EventHandler(this.toolRemoveDrug_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(527, 645);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(160, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(361, 645);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(160, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llPrintPrescription
            // 
            this.llPrintPrescription.AutoSize = true;
            this.llPrintPrescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPrintPrescription.Location = new System.Drawing.Point(20, 651);
            this.llPrintPrescription.Name = "llPrintPrescription";
            this.llPrintPrescription.Size = new System.Drawing.Size(141, 23);
            this.llPrintPrescription.TabIndex = 11;
            this.llPrintPrescription.TabStop = true;
            this.llPrintPrescription.Text = "Print Prescription";
            this.llPrintPrescription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPrintPrescription_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(46, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "Prescription ID:";
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionID.ForeColor = System.Drawing.Color.Red;
            this.lblPrescriptionID.Location = new System.Drawing.Point(152, 74);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(47, 21);
            this.lblPrescriptionID.TabIndex = 13;
            this.lblPrescriptionID.Text = "[###]";
            this.lblPrescriptionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmIssuePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 695);
            this.Controls.Add(this.lblPrescriptionID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.llPrintPrescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvDrugsList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIssuePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prescriptions";
            this.Load += new System.EventHandler(this.frmIssuePrescription_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDrugPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbDuration;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.ComboBox cbDosage;
        private Guna.UI.WinForms.GunaImageButton btnAddDrug;
        private System.Windows.Forms.DataGridView dgvDrugsList;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.LinkLabel llPrintPrescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolUpdateDrug;
        private System.Windows.Forms.ToolStripMenuItem toolRemoveDrug;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPrescriptionID;
        private Guna.UI.WinForms.GunaImageButton btnDrugUpdate;
    }
}