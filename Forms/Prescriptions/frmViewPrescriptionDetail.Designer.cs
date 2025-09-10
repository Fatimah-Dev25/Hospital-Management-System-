namespace HospitalManagementSystem.Forms.Prescriptions
{
    partial class frmViewPrescriptionDetail
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
            this.lblPresID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPresDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrescriptionDoctor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrescriptionFor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.llPrintPrescription = new System.Windows.Forms.LinkLabel();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.dgvPresDrugs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPresID
            // 
            this.lblPresID.AutoSize = true;
            this.lblPresID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblPresID.ForeColor = System.Drawing.Color.Red;
            this.lblPresID.Location = new System.Drawing.Point(154, 71);
            this.lblPresID.Name = "lblPresID";
            this.lblPresID.Size = new System.Drawing.Size(47, 21);
            this.lblPresID.TabIndex = 22;
            this.lblPresID.Text = "[###]";
            this.lblPresID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(23, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Prescription ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.systemLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblPresDate
            // 
            this.lblPresDate.AutoSize = true;
            this.lblPresDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblPresDate.Location = new System.Drawing.Point(429, 72);
            this.lblPresDate.Name = "lblPresDate";
            this.lblPresDate.Size = new System.Drawing.Size(80, 21);
            this.lblPresDate.TabIndex = 19;
            this.lblPresDate.Text = "??/??/????";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(360, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date:";
            // 
            // lblPrescriptionDoctor
            // 
            this.lblPrescriptionDoctor.AutoSize = true;
            this.lblPrescriptionDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionDoctor.Location = new System.Drawing.Point(487, 112);
            this.lblPrescriptionDoctor.Name = "lblPrescriptionDoctor";
            this.lblPrescriptionDoctor.Size = new System.Drawing.Size(45, 21);
            this.lblPrescriptionDoctor.TabIndex = 17;
            this.lblPrescriptionDoctor.Text = "?????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(360, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Doctor Name:";
            // 
            // lblPrescriptionFor
            // 
            this.lblPrescriptionFor.AutoSize = true;
            this.lblPrescriptionFor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblPrescriptionFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblPrescriptionFor.Location = new System.Drawing.Point(146, 112);
            this.lblPrescriptionFor.Name = "lblPrescriptionFor";
            this.lblPrescriptionFor.Size = new System.Drawing.Size(45, 21);
            this.lblPrescriptionFor.TabIndex = 15;
            this.lblPrescriptionFor.Text = "?????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Patient Name:";
            // 
            // llPrintPrescription
            // 
            this.llPrintPrescription.AutoSize = true;
            this.llPrintPrescription.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llPrintPrescription.Location = new System.Drawing.Point(28, 459);
            this.llPrintPrescription.Name = "llPrintPrescription";
            this.llPrintPrescription.Size = new System.Drawing.Size(141, 23);
            this.llPrintPrescription.TabIndex = 25;
            this.llPrintPrescription.TabStop = true;
            this.llPrintPrescription.Text = "Print Prescription";
            this.llPrintPrescription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPrintPrescription_LinkClicked);
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
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(540, 452);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.DarkGray;
            this.btnClose.Radius = 10;
            this.btnClose.Size = new System.Drawing.Size(160, 36);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPresDrugs
            // 
            this.dgvPresDrugs.AllowUserToAddRows = false;
            this.dgvPresDrugs.BackgroundColor = System.Drawing.Color.White;
            this.dgvPresDrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresDrugs.Location = new System.Drawing.Point(12, 161);
            this.dgvPresDrugs.Name = "dgvPresDrugs";
            this.dgvPresDrugs.RowHeadersVisible = false;
            this.dgvPresDrugs.RowHeadersWidth = 51;
            this.dgvPresDrugs.RowTemplate.Height = 24;
            this.dgvPresDrugs.Size = new System.Drawing.Size(688, 269);
            this.dgvPresDrugs.TabIndex = 23;
            // 
            // frmViewPrescriptionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 506);
            this.Controls.Add(this.llPrintPrescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPresDrugs);
            this.Controls.Add(this.lblPresID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPresDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPrescriptionDoctor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrescriptionFor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewPrescriptionDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prescription Detail";
            this.Load += new System.EventHandler(this.frmViewPrescriptionDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPresID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPresDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrescriptionDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrescriptionFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llPrintPrescription;
        private Guna.UI.WinForms.GunaButton btnClose;
        private System.Windows.Forms.DataGridView dgvPresDrugs;
    }
}