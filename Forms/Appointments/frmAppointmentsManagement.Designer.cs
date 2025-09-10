namespace HospitalManagementSystem.Forms.Appointments
{
    partial class frmAppointmentsManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllAppointments = new System.Windows.Forms.DataGridView();
            this.AppointmentsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.issueNewRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.linkAppointmentToRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentConfirm = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentComplete = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.dtAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAppointments)).BeginInit();
            this.AppointmentsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllAppointments
            // 
            this.dgvAllAppointments.AllowUserToAddRows = false;
            this.dgvAllAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllAppointments.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAppointments.ContextMenuStrip = this.AppointmentsMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(83)))), ((int)(((byte)(14)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllAppointments.Location = new System.Drawing.Point(12, 150);
            this.dgvAllAppointments.Name = "dgvAllAppointments";
            this.dgvAllAppointments.RowHeadersVisible = false;
            this.dgvAllAppointments.RowHeadersWidth = 51;
            this.dgvAllAppointments.RowTemplate.Height = 24;
            this.dgvAllAppointments.Size = new System.Drawing.Size(1235, 505);
            this.dgvAllAppointments.TabIndex = 1;
            this.dgvAllAppointments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllAppointments_CellFormatting);
            // 
            // AppointmentsMenu
            // 
            this.AppointmentsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(254)))), ((int)(((byte)(231)))));
            this.AppointmentsMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.AppointmentsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.AppointmentsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAppointment,
            this.issueNewRecord,
            this.linkAppointmentToRecord,
            this.updateAppointment,
            this.AppointmentConfirm,
            this.AppointmentComplete,
            this.AppointmentCancel,
            this.deleteAppointment});
            this.AppointmentsMenu.Name = "AppointmentsMenu";
            this.AppointmentsMenu.Size = new System.Drawing.Size(271, 240);
            // 
            // addNewAppointment
            // 
            this.addNewAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.addNewAppointment.Image = global::HospitalManagementSystem.Properties.Resources.appointments1;
            this.addNewAppointment.Name = "addNewAppointment";
            this.addNewAppointment.Size = new System.Drawing.Size(270, 26);
            this.addNewAppointment.Text = "Add New Appointment";
            this.addNewAppointment.Click += new System.EventHandler(this.addNewAppointment_Click);
            // 
            // issueNewRecord
            // 
            this.issueNewRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.issueNewRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.issueNewRecord.Image = global::HospitalManagementSystem.Properties.Resources.notes;
            this.issueNewRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueNewRecord.Name = "issueNewRecord";
            this.issueNewRecord.Size = new System.Drawing.Size(270, 26);
            this.issueNewRecord.Text = "Issue Record";
            this.issueNewRecord.Click += new System.EventHandler(this.issueNewRecord_Click);
            // 
            // linkAppointmentToRecord
            // 
            this.linkAppointmentToRecord.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.linkAppointmentToRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.linkAppointmentToRecord.Image = global::HospitalManagementSystem.Properties.Resources.link;
            this.linkAppointmentToRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.linkAppointmentToRecord.Name = "linkAppointmentToRecord";
            this.linkAppointmentToRecord.Size = new System.Drawing.Size(270, 26);
            this.linkAppointmentToRecord.Text = "Link to Existing Record";
            this.linkAppointmentToRecord.Click += new System.EventHandler(this.linkAppointmentToRecord_Click);
            // 
            // updateAppointment
            // 
            this.updateAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.updateAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.updateAppointment.Image = global::HospitalManagementSystem.Properties.Resources.loading__1_;
            this.updateAppointment.Name = "updateAppointment";
            this.updateAppointment.Size = new System.Drawing.Size(270, 26);
            this.updateAppointment.Text = "Update Appointment Detail";
            this.updateAppointment.Click += new System.EventHandler(this.updateAppointment_Click);
            // 
            // AppointmentConfirm
            // 
            this.AppointmentConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.AppointmentConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.AppointmentConfirm.Name = "AppointmentConfirm";
            this.AppointmentConfirm.Size = new System.Drawing.Size(270, 26);
            this.AppointmentConfirm.Text = "Confirm";
            this.AppointmentConfirm.Click += new System.EventHandler(this.AppointmentConfirm_Click);
            // 
            // AppointmentComplete
            // 
            this.AppointmentComplete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.AppointmentComplete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.AppointmentComplete.Name = "AppointmentComplete";
            this.AppointmentComplete.Size = new System.Drawing.Size(270, 26);
            this.AppointmentComplete.Text = "Complete";
            this.AppointmentComplete.Click += new System.EventHandler(this.AppointmentComplete_Click);
            // 
            // AppointmentCancel
            // 
            this.AppointmentCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.AppointmentCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.AppointmentCancel.Name = "AppointmentCancel";
            this.AppointmentCancel.Size = new System.Drawing.Size(270, 26);
            this.AppointmentCancel.Text = "Cancel";
            this.AppointmentCancel.Click += new System.EventHandler(this.AppointmentCancel_Click);
            // 
            // deleteAppointment
            // 
            this.deleteAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.deleteAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.deleteAppointment.Image = global::HospitalManagementSystem.Properties.Resources.remove;
            this.deleteAppointment.Name = "deleteAppointment";
            this.deleteAppointment.Size = new System.Drawing.Size(270, 26);
            this.deleteAppointment.Text = "Delete";
            this.deleteAppointment.Click += new System.EventHandler(this.deleteAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(92, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appointments Management";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Patient Name",
            "File Number",
            "Doctor",
            "Department",
            "Date"});
            this.cbFilterBy.Location = new System.Drawing.Point(127, 103);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(160, 28);
            this.cbFilterBy.TabIndex = 5;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By:";
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(298, 103);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(194, 27);
            this.txtFilterBy.TabIndex = 7;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(300, 103);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(192, 24);
            this.cbDepartments.TabIndex = 8;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
            // 
            // dtAppointmentDate
            // 
            this.dtAppointmentDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.2F);
            this.dtAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAppointmentDate.Location = new System.Drawing.Point(300, 103);
            this.dtAppointmentDate.Name = "dtAppointmentDate";
            this.dtAppointmentDate.Size = new System.Drawing.Size(161, 22);
            this.dtAppointmentDate.TabIndex = 9;
            this.dtAppointmentDate.ValueChanged += new System.EventHandler(this.dtAppointmentDate_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.aaaa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(60, 668);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(843, 23);
            this.label17.TabIndex = 31;
            this.label17.Text = "Note: A green background indicates that the appointment is linked to a medical re" +
    "cord. Otherwise, it is not.";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(249)))), ((int)(((byte)(153)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(249)))), ((int)(((byte)(153)))));
            this.label16.Location = new System.Drawing.Point(17, 665);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 28);
            this.label16.TabIndex = 30;
            this.label16.Text = "🟨";
            // 
            // frmAppointmentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1259, 709);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dtAppointmentDate);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAllAppointments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppointmentsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointments Management";
            this.Load += new System.EventHandler(this.frmAppointmentsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAppointments)).EndInit();
            this.AppointmentsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAllAppointments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.DateTimePicker dtAppointmentDate;
        private System.Windows.Forms.ContextMenuStrip AppointmentsMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewAppointment;
        private System.Windows.Forms.ToolStripMenuItem issueNewRecord;
        private System.Windows.Forms.ToolStripMenuItem linkAppointmentToRecord;
        private System.Windows.Forms.ToolStripMenuItem updateAppointment;
        private System.Windows.Forms.ToolStripMenuItem AppointmentConfirm;
        private System.Windows.Forms.ToolStripMenuItem AppointmentComplete;
        private System.Windows.Forms.ToolStripMenuItem AppointmentCancel;
        private System.Windows.Forms.ToolStripMenuItem deleteAppointment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}