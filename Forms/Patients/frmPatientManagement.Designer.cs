namespace HospitalManagementSystem.Forms.Patients
{
    partial class frmPatientManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPatientsList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterby = new System.Windows.Forms.TextBox();
            this.btnExportData = new Guna.UI.WinForms.GunaButton();
            this.btnAddPatient = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatientsList
            // 
            this.dgvPatientsList.AllowUserToAddRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.dgvPatientsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPatientsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientsList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPatientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatientsList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPatientsList.Location = new System.Drawing.Point(15, 154);
            this.dgvPatientsList.Name = "dgvPatientsList";
            this.dgvPatientsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPatientsList.RowHeadersVisible = false;
            this.dgvPatientsList.RowHeadersWidth = 51;
            this.dgvPatientsList.RowTemplate.Height = 30;
            this.dgvPatientsList.Size = new System.Drawing.Size(1295, 612);
            this.dgvPatientsList.TabIndex = 1;
            this.dgvPatientsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientsList_CellClick);
            this.dgvPatientsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientsList_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(17, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "File Number",
            "Patient Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(100, 115);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(153, 31);
            this.cbFilterBy.TabIndex = 5;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterby
            // 
            this.txtFilterby.Location = new System.Drawing.Point(255, 116);
            this.txtFilterby.Name = "txtFilterby";
            this.txtFilterby.Size = new System.Drawing.Size(202, 30);
            this.txtFilterby.TabIndex = 6;
            this.txtFilterby.TextChanged += new System.EventHandler(this.txtFilterby_TextChanged);
            // 
            // btnExportData
            // 
            this.btnExportData.AnimationHoverSpeed = 0.07F;
            this.btnExportData.AnimationSpeed = 0.03F;
            this.btnExportData.BackColor = System.Drawing.Color.Transparent;
            this.btnExportData.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnExportData.BorderColor = System.Drawing.Color.Black;
            this.btnExportData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportData.FocusedColor = System.Drawing.Color.Empty;
            this.btnExportData.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.ForeColor = System.Drawing.Color.White;
            this.btnExportData.Image = global::HospitalManagementSystem.Properties.Resources.icons8_export_32;
            this.btnExportData.ImageSize = new System.Drawing.Size(29, 29);
            this.btnExportData.Location = new System.Drawing.Point(463, 110);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnExportData.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExportData.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportData.OnHoverImage = null;
            this.btnExportData.OnPressedColor = System.Drawing.Color.DarkSlateGray;
            this.btnExportData.Radius = 8;
            this.btnExportData.Size = new System.Drawing.Size(132, 36);
            this.btnExportData.TabIndex = 7;
            this.btnExportData.Text = "Export";
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatient.AnimationHoverSpeed = 0.07F;
            this.btnAddPatient.AnimationSpeed = 0.03F;
            this.btnAddPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPatient.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddPatient.BorderColor = System.Drawing.Color.Black;
            this.btnAddPatient.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPatient.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Image = global::HospitalManagementSystem.Properties.Resources.icons8_add_641;
            this.btnAddPatient.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAddPatient.Location = new System.Drawing.Point(1122, 110);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddPatient.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddPatient.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddPatient.OnHoverImage = null;
            this.btnAddPatient.OnPressedColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddPatient.Radius = 8;
            this.btnAddPatient.Size = new System.Drawing.Size(184, 36);
            this.btnAddPatient.TabIndex = 3;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(1, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1322, 778);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportData);
            this.Controls.Add(this.txtFilterby);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPatientsList);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPatientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Management";
            this.Load += new System.EventHandler(this.frmPatientManagement_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPatientsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnAddPatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterby;
        private Guna.UI.WinForms.GunaButton btnExportData;
    }
}