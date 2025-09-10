namespace HospitalManagementSystem.Forms.Doctors
{
    partial class DoctorCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btnViewDetail = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnCall = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblHiredDate = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblExperienceYears = new System.Windows.Forms.Label();
            this.lblSPECIALITY = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.pbDoctorImage = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.btnViewDetail);
            this.gunaGradient2Panel1.Controls.Add(this.btnEdit);
            this.gunaGradient2Panel1.Controls.Add(this.btnDelete);
            this.gunaGradient2Panel1.Controls.Add(this.btnCall);
            this.gunaGradient2Panel1.Controls.Add(this.lblHiredDate);
            this.gunaGradient2Panel1.Controls.Add(this.lblBirthDate);
            this.gunaGradient2Panel1.Controls.Add(this.lblExperienceYears);
            this.gunaGradient2Panel1.Controls.Add(this.lblSPECIALITY);
            this.gunaGradient2Panel1.Controls.Add(this.label4);
            this.gunaGradient2Panel1.Controls.Add(this.label3);
            this.gunaGradient2Panel1.Controls.Add(this.label2);
            this.gunaGradient2Panel1.Controls.Add(this.label1);
            this.gunaGradient2Panel1.Controls.Add(this.lblDoctorName);
            this.gunaGradient2Panel1.Controls.Add(this.pbDoctorImage);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 3);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 20;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(378, 508);
            this.gunaGradient2Panel1.TabIndex = 0;
            this.gunaGradient2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel1_Paint);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetail.Image = global::HospitalManagementSystem.Properties.Resources.info;
            this.btnViewDetail.Location = new System.Drawing.Point(16, 455);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(32, 32);
            this.btnViewDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnViewDetail.TabIndex = 12;
            this.btnViewDetail.TabStop = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Image = global::HospitalManagementSystem.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(57, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 32);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::HospitalManagementSystem.Properties.Resources.delete2;
            this.btnDelete.Location = new System.Drawing.Point(96, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 1;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCall
            // 
            this.btnCall.AnimationHoverSpeed = 0.07F;
            this.btnCall.AnimationSpeed = 0.03F;
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.BaseColor = System.Drawing.Color.Transparent;
            this.btnCall.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.btnCall.BorderSize = 1;
            this.btnCall.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCall.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCall.CheckedForeColor = System.Drawing.Color.White;
            this.btnCall.CheckedImage = global::HospitalManagementSystem.Properties.Resources.phone_call1;
            this.btnCall.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCall.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCall.FocusedColor = System.Drawing.Color.Empty;
            this.btnCall.Font = new System.Drawing.Font("Showcard Gothic", 11F);
            this.btnCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnCall.Image = global::HospitalManagementSystem.Properties.Resources.telephone_call;
            this.btnCall.ImageSize = new System.Drawing.Size(24, 24);
            this.btnCall.LineColor = System.Drawing.Color.Transparent;
            this.btnCall.Location = new System.Drawing.Point(137, 447);
            this.btnCall.Name = "btnCall";
            this.btnCall.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnCall.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCall.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.btnCall.OnHoverImage = null;
            this.btnCall.OnHoverLineColor = System.Drawing.Color.Purple;
            this.btnCall.OnPressedColor = System.Drawing.Color.Black;
            this.btnCall.OnPressedDepth = 0;
            this.btnCall.Radius = 25;
            this.btnCall.Size = new System.Drawing.Size(232, 44);
            this.btnCall.TabIndex = 10;
            this.btnCall.Text = "+971 50 210 41 77";
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // lblHiredDate
            // 
            this.lblHiredDate.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold);
            this.lblHiredDate.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblHiredDate.Location = new System.Drawing.Point(122, 398);
            this.lblHiredDate.Name = "lblHiredDate";
            this.lblHiredDate.Size = new System.Drawing.Size(237, 23);
            this.lblHiredDate.TabIndex = 9;
            this.lblHiredDate.Text = "??/??/????";
            this.lblHiredDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold);
            this.lblBirthDate.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblBirthDate.Location = new System.Drawing.Point(125, 357);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(234, 23);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "??/??/????";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBirthDate.Click += new System.EventHandler(this.lblBirthDate_Click);
            // 
            // lblExperienceYears
            // 
            this.lblExperienceYears.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold);
            this.lblExperienceYears.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblExperienceYears.Location = new System.Drawing.Point(191, 316);
            this.lblExperienceYears.Name = "lblExperienceYears";
            this.lblExperienceYears.Size = new System.Drawing.Size(130, 23);
            this.lblExperienceYears.TabIndex = 7;
            this.lblExperienceYears.Text = "[??] ";
            this.lblExperienceYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSPECIALITY
            // 
            this.lblSPECIALITY.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Bold);
            this.lblSPECIALITY.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblSPECIALITY.Location = new System.Drawing.Point(122, 275);
            this.lblSPECIALITY.Name = "lblSPECIALITY";
            this.lblSPECIALITY.Size = new System.Drawing.Size(256, 23);
            this.lblSPECIALITY.TabIndex = 6;
            this.lblSPECIALITY.Text = "?????";
            this.lblSPECIALITY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Rockwell", 8.6F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(10, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "DATE HIRED:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Rockwell", 8.6F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(10, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "BIRTH DATE:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rockwell", 8.6F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(10, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "EXPERIENCE YEARS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell", 8.6F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(10, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "SPECIALITY:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Bold);
            this.lblDoctorName.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblDoctorName.Location = new System.Drawing.Point(18, 215);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(332, 23);
            this.lblDoctorName.TabIndex = 1;
            this.lblDoctorName.Text = "Dr. ";
            this.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbDoctorImage
            // 
            this.pbDoctorImage.BackColor = System.Drawing.Color.Transparent;
            this.pbDoctorImage.BaseColor = System.Drawing.Color.White;
            this.pbDoctorImage.Image = global::HospitalManagementSystem.Properties.Resources.doctor__1_1;
            this.pbDoctorImage.Location = new System.Drawing.Point(108, 20);
            this.pbDoctorImage.Name = "pbDoctorImage";
            this.pbDoctorImage.Radius = 14;
            this.pbDoctorImage.Size = new System.Drawing.Size(148, 160);
            this.pbDoctorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDoctorImage.TabIndex = 0;
            this.pbDoctorImage.TabStop = false;
            // 
            // DoctorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Margin = new System.Windows.Forms.Padding(30, 20, 20, 20);
            this.Name = "DoctorCard";
            this.Size = new System.Drawing.Size(377, 511);
            this.gunaGradient2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnViewDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoctorImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaPictureBox pbDoctorImage;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHiredDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblExperienceYears;
        private System.Windows.Forms.Label lblSPECIALITY;
        private Guna.UI.WinForms.GunaAdvenceButton btnCall;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnViewDetail;
    }
}
