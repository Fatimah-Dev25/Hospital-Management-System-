namespace HospitalManagementSystem.Forms.LabTests
{
    partial class frmLabTestsManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllLabTests = new System.Windows.Forms.DataGridView();
            this.cbFilterTestsBy = new System.Windows.Forms.ComboBox();
            this.txtFilterTests = new System.Windows.Forms.TextBox();
            this.dtpFilterByDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llTestTypeManagement = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDeleteTest = new Guna.UI.WinForms.GunaButton();
            this.btnAddResult = new Guna.UI.WinForms.GunaButton();
            this.btnUpdateTest = new Guna.UI.WinForms.GunaButton();
            this.btnAddLabTest = new Guna.UI.WinForms.GunaButton();
            this.btnPerformFilter = new Guna.UI.WinForms.GunaPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLabTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPerformFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllLabTests
            // 
            this.dgvAllLabTests.AllowUserToAddRows = false;
            this.dgvAllLabTests.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllLabTests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllLabTests.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllLabTests.GridColor = System.Drawing.Color.Lavender;
            this.dgvAllLabTests.Location = new System.Drawing.Point(12, 27);
            this.dgvAllLabTests.Name = "dgvAllLabTests";
            this.dgvAllLabTests.RowHeadersVisible = false;
            this.dgvAllLabTests.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAllLabTests.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllLabTests.RowTemplate.Height = 24;
            this.dgvAllLabTests.Size = new System.Drawing.Size(800, 702);
            this.dgvAllLabTests.TabIndex = 0;
            // 
            // cbFilterTestsBy
            // 
            this.cbFilterTestsBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterTestsBy.FormattingEnabled = true;
            this.cbFilterTestsBy.Items.AddRange(new object[] {
            "None",
            "Patient File",
            "Patient Name",
            "Doctor Name",
            "Test Date"});
            this.cbFilterTestsBy.Location = new System.Drawing.Point(818, 72);
            this.cbFilterTestsBy.Name = "cbFilterTestsBy";
            this.cbFilterTestsBy.Size = new System.Drawing.Size(156, 28);
            this.cbFilterTestsBy.TabIndex = 2;
            this.cbFilterTestsBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterTestsBy_SelectedIndexChanged);
            // 
            // txtFilterTests
            // 
            this.txtFilterTests.Location = new System.Drawing.Point(980, 73);
            this.txtFilterTests.Name = "txtFilterTests";
            this.txtFilterTests.Size = new System.Drawing.Size(225, 27);
            this.txtFilterTests.TabIndex = 3;
            this.txtFilterTests.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterTests_KeyPress);
            // 
            // dtpFilterByDate
            // 
            this.dtpFilterByDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterByDate.Location = new System.Drawing.Point(980, 73);
            this.dtpFilterByDate.Name = "dtpFilterByDate";
            this.dtpFilterByDate.Size = new System.Drawing.Size(200, 27);
            this.dtpFilterByDate.TabIndex = 5;
            this.dtpFilterByDate.Visible = false;
            this.dtpFilterByDate.ValueChanged += new System.EventHandler(this.dtpFilterByDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.4F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(827, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 47);
            this.label1.TabIndex = 10;
            this.label1.Text = "Please select Test you would like to perform operation on from List.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.4F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(868, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tests Settings:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llTestTypeManagement
            // 
            this.llTestTypeManagement.AutoSize = true;
            this.llTestTypeManagement.Font = new System.Drawing.Font("Segoe UI Semibold", 9.6F, System.Drawing.FontStyle.Bold);
            this.llTestTypeManagement.Location = new System.Drawing.Point(880, 619);
            this.llTestTypeManagement.Name = "llTestTypeManagement";
            this.llTestTypeManagement.Size = new System.Drawing.Size(141, 21);
            this.llTestTypeManagement.TabIndex = 12;
            this.llTestTypeManagement.TabStop = true;
            this.llTestTypeManagement.Text = "Manage Test Type";
            this.llTestTypeManagement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llTestTypeManagement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTestTypeManagement_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HospitalManagementSystem.Properties.Resources.icons8_settings_32;
            this.pictureBox2.Location = new System.Drawing.Point(834, 580);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.AnimationHoverSpeed = 0.07F;
            this.btnDeleteTest.AnimationSpeed = 0.03F;
            this.btnDeleteTest.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTest.BaseColor = System.Drawing.Color.Transparent;
            this.btnDeleteTest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnDeleteTest.BorderSize = 1;
            this.btnDeleteTest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteTest.FocusedColor = System.Drawing.Color.Empty;
            this.btnDeleteTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnDeleteTest.Image = global::HospitalManagementSystem.Properties.Resources.icons8_delete_32;
            this.btnDeleteTest.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDeleteTest.Location = new System.Drawing.Point(831, 410);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.OnHoverBaseColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDeleteTest.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnDeleteTest.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDeleteTest.OnHoverImage = null;
            this.btnDeleteTest.OnPressedColor = System.Drawing.Color.Black;
            this.btnDeleteTest.Radius = 8;
            this.btnDeleteTest.Size = new System.Drawing.Size(168, 36);
            this.btnDeleteTest.TabIndex = 9;
            this.btnDeleteTest.Text = "Delete";
            this.btnDeleteTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            // 
            // btnAddResult
            // 
            this.btnAddResult.AnimationHoverSpeed = 0.07F;
            this.btnAddResult.AnimationSpeed = 0.03F;
            this.btnAddResult.BackColor = System.Drawing.Color.Transparent;
            this.btnAddResult.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddResult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnAddResult.BorderSize = 1;
            this.btnAddResult.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddResult.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddResult.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnAddResult.Image = global::HospitalManagementSystem.Properties.Resources.icons8_chemical_test_32;
            this.btnAddResult.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAddResult.Location = new System.Drawing.Point(831, 356);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.OnHoverBaseColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddResult.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnAddResult.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddResult.OnHoverImage = null;
            this.btnAddResult.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddResult.Radius = 8;
            this.btnAddResult.Size = new System.Drawing.Size(168, 36);
            this.btnAddResult.TabIndex = 8;
            this.btnAddResult.Text = "Add Result";
            this.btnAddResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // btnUpdateTest
            // 
            this.btnUpdateTest.AnimationHoverSpeed = 0.07F;
            this.btnUpdateTest.AnimationSpeed = 0.03F;
            this.btnUpdateTest.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateTest.BaseColor = System.Drawing.Color.Transparent;
            this.btnUpdateTest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnUpdateTest.BorderSize = 1;
            this.btnUpdateTest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdateTest.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdateTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnUpdateTest.Image = global::HospitalManagementSystem.Properties.Resources.icons8_update_32;
            this.btnUpdateTest.ImageSize = new System.Drawing.Size(24, 24);
            this.btnUpdateTest.Location = new System.Drawing.Point(831, 302);
            this.btnUpdateTest.Name = "btnUpdateTest";
            this.btnUpdateTest.OnHoverBaseColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdateTest.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnUpdateTest.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdateTest.OnHoverImage = null;
            this.btnUpdateTest.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdateTest.Radius = 8;
            this.btnUpdateTest.Size = new System.Drawing.Size(168, 36);
            this.btnUpdateTest.TabIndex = 7;
            this.btnUpdateTest.Text = "  Update Test";
            this.btnUpdateTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdateTest.Click += new System.EventHandler(this.btnUpdateTest_Click);
            // 
            // btnAddLabTest
            // 
            this.btnAddLabTest.AnimationHoverSpeed = 0.07F;
            this.btnAddLabTest.AnimationSpeed = 0.03F;
            this.btnAddLabTest.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLabTest.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddLabTest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnAddLabTest.BorderSize = 1;
            this.btnAddLabTest.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddLabTest.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddLabTest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLabTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnAddLabTest.Image = global::HospitalManagementSystem.Properties.Resources.icons8_add_322;
            this.btnAddLabTest.ImageSize = new System.Drawing.Size(28, 28);
            this.btnAddLabTest.Location = new System.Drawing.Point(831, 248);
            this.btnAddLabTest.Name = "btnAddLabTest";
            this.btnAddLabTest.OnHoverBaseColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddLabTest.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.btnAddLabTest.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddLabTest.OnHoverImage = null;
            this.btnAddLabTest.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddLabTest.Radius = 8;
            this.btnAddLabTest.Size = new System.Drawing.Size(168, 36);
            this.btnAddLabTest.TabIndex = 6;
            this.btnAddLabTest.Text = "Add Test";
            this.btnAddLabTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddLabTest.Click += new System.EventHandler(this.btnAddLabTest_Click);
            // 
            // btnPerformFilter
            // 
            this.btnPerformFilter.BaseColor = System.Drawing.Color.White;
            this.btnPerformFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerformFilter.Image = global::HospitalManagementSystem.Properties.Resources.filter__1_1;
            this.btnPerformFilter.Location = new System.Drawing.Point(1209, 73);
            this.btnPerformFilter.Name = "btnPerformFilter";
            this.btnPerformFilter.Size = new System.Drawing.Size(24, 24);
            this.btnPerformFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPerformFilter.TabIndex = 4;
            this.btnPerformFilter.TabStop = false;
            this.btnPerformFilter.Click += new System.EventHandler(this.btnPerformFilter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.SmallTransperntlogo;
            this.pictureBox1.Location = new System.Drawing.Point(818, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmLabTestsManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 741);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.llTestTypeManagement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteTest);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.btnUpdateTest);
            this.Controls.Add(this.btnAddLabTest);
            this.Controls.Add(this.dtpFilterByDate);
            this.Controls.Add(this.btnPerformFilter);
            this.Controls.Add(this.txtFilterTests);
            this.Controls.Add(this.cbFilterTestsBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAllLabTests);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLabTestsManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lab Tests Management";
            this.Load += new System.EventHandler(this.frmLabTestsManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLabTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPerformFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllLabTests;
        private System.Windows.Forms.ComboBox cbFilterTestsBy;
        private System.Windows.Forms.TextBox txtFilterTests;
        private Guna.UI.WinForms.GunaPictureBox btnPerformFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterByDate;
        private Guna.UI.WinForms.GunaButton btnAddLabTest;
        private Guna.UI.WinForms.GunaButton btnUpdateTest;
        private Guna.UI.WinForms.GunaButton btnAddResult;
        private Guna.UI.WinForms.GunaButton btnDeleteTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llTestTypeManagement;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}