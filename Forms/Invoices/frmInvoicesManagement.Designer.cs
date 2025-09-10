namespace HospitalManagementSystem.Forms.Invoices
{
    partial class frmInvoicesManagement
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
            this.dgvAllInvoices = new System.Windows.Forms.DataGridView();
            this.InvoicesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payFullToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPartialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyDiscountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistorytoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbViewPendingInvoices = new Guna.UI.WinForms.GunaRadioButton();
            this.rbAllInvoices = new Guna.UI.WinForms.GunaRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterInvoicesBy = new System.Windows.Forms.ComboBox();
            this.txtFilterInvoicesValue = new System.Windows.Forms.TextBox();
            this.dtpFilterInvoicesValue = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInvoicesCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInvoices)).BeginInit();
            this.InvoicesMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllInvoices
            // 
            this.dgvAllInvoices.AllowUserToAddRows = false;
            this.dgvAllInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllInvoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dgvAllInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllInvoices.ContextMenuStrip = this.InvoicesMenu;
            this.dgvAllInvoices.Location = new System.Drawing.Point(12, 147);
            this.dgvAllInvoices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllInvoices.Name = "dgvAllInvoices";
            this.dgvAllInvoices.RowHeadersVisible = false;
            this.dgvAllInvoices.RowHeadersWidth = 51;
            this.dgvAllInvoices.RowTemplate.Height = 24;
            this.dgvAllInvoices.Size = new System.Drawing.Size(1153, 514);
            this.dgvAllInvoices.TabIndex = 0;
            this.dgvAllInvoices.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllInvoices_CellFormatting);
            this.dgvAllInvoices.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllInvoices_CellMouseDown);
            // 
            // InvoicesMenu
            // 
            this.InvoicesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.InvoicesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDetailToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.payInvoiceToolStripMenuItem,
            this.applyDiscountToolStripMenuItem,
            this.paymentHistorytoolStripMenuItem,
            this.CancelToolStripMenuItem});
            this.InvoicesMenu.Name = "InvoicesMenu";
            this.InvoicesMenu.Size = new System.Drawing.Size(230, 184);
            this.InvoicesMenu.Opening += new System.ComponentModel.CancelEventHandler(this.InvoicesMenu_Opening);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.viewDetailToolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.invoice1;
            this.viewDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.viewDetailToolStripMenuItem.Text = "View Detail";
            this.viewDetailToolStripMenuItem.Click += new System.EventHandler(this.viewDetailToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // payInvoiceToolStripMenuItem
            // 
            this.payInvoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payFullToolStripMenuItem,
            this.payPartialToolStripMenuItem});
            this.payInvoiceToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.payInvoiceToolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.pay;
            this.payInvoiceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.payInvoiceToolStripMenuItem.Name = "payInvoiceToolStripMenuItem";
            this.payInvoiceToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.payInvoiceToolStripMenuItem.Text = "Pay Invoice";
            this.payInvoiceToolStripMenuItem.Click += new System.EventHandler(this.checkItemsToolStripMenuItem_Click);
            // 
            // payFullToolStripMenuItem
            // 
            this.payFullToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.payFullToolStripMenuItem.Name = "payFullToolStripMenuItem";
            this.payFullToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.payFullToolStripMenuItem.Text = "Pay Full";
            this.payFullToolStripMenuItem.Click += new System.EventHandler(this.payFullToolStripMenuItem_Click);
            // 
            // payPartialToolStripMenuItem
            // 
            this.payPartialToolStripMenuItem.Name = "payPartialToolStripMenuItem";
            this.payPartialToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.payPartialToolStripMenuItem.Text = "Pay Partial";
            this.payPartialToolStripMenuItem.Click += new System.EventHandler(this.payPartialToolStripMenuItem_Click);
            // 
            // applyDiscountToolStripMenuItem
            // 
            this.applyDiscountToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.applyDiscountToolStripMenuItem.Name = "applyDiscountToolStripMenuItem";
            this.applyDiscountToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.applyDiscountToolStripMenuItem.Text = "Apply Discount";
            this.applyDiscountToolStripMenuItem.Click += new System.EventHandler(this.applyDiscountToolStripMenuItem_Click);
            // 
            // paymentHistorytoolStripMenuItem
            // 
            this.paymentHistorytoolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.paymentHistorytoolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.bill;
            this.paymentHistorytoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paymentHistorytoolStripMenuItem.Name = "paymentHistorytoolStripMenuItem";
            this.paymentHistorytoolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.paymentHistorytoolStripMenuItem.Text = "View Payment History";
            this.paymentHistorytoolStripMenuItem.Click += new System.EventHandler(this.paymentHistorytoolStripMenuItem_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.CancelToolStripMenuItem.Image = global::HospitalManagementSystem.Properties.Resources.forbidden;
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.CancelToolStripMenuItem.Text = "Cancel";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // rbViewPendingInvoices
            // 
            this.rbViewPendingInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbViewPendingInvoices.BaseColor = System.Drawing.SystemColors.Control;
            this.rbViewPendingInvoices.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbViewPendingInvoices.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbViewPendingInvoices.FillColor = System.Drawing.Color.White;
            this.rbViewPendingInvoices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbViewPendingInvoices.Location = new System.Drawing.Point(1043, 109);
            this.rbViewPendingInvoices.Name = "rbViewPendingInvoices";
            this.rbViewPendingInvoices.Size = new System.Drawing.Size(89, 24);
            this.rbViewPendingInvoices.TabIndex = 2;
            this.rbViewPendingInvoices.Text = "Pending";
            this.rbViewPendingInvoices.CheckedChanged += new System.EventHandler(this.rbViewPendingInvoices_CheckedChanged);
            // 
            // rbAllInvoices
            // 
            this.rbAllInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAllInvoices.BaseColor = System.Drawing.SystemColors.Control;
            this.rbAllInvoices.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbAllInvoices.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rbAllInvoices.FillColor = System.Drawing.Color.White;
            this.rbAllInvoices.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAllInvoices.Location = new System.Drawing.Point(991, 109);
            this.rbAllInvoices.Name = "rbAllInvoices";
            this.rbAllInvoices.Size = new System.Drawing.Size(49, 24);
            this.rbAllInvoices.TabIndex = 3;
            this.rbAllInvoices.Text = "All";
            this.rbAllInvoices.CheckedChanged += new System.EventHandler(this.rbAllInvoices_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(928, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "View By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbFilterInvoicesBy
            // 
            this.cbFilterInvoicesBy.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbFilterInvoicesBy.FormattingEnabled = true;
            this.cbFilterInvoicesBy.Items.AddRange(new object[] {
            "None",
            "Record Number",
            "Patient File",
            "Patient Name",
            "Invoice Date"});
            this.cbFilterInvoicesBy.Location = new System.Drawing.Point(112, 105);
            this.cbFilterInvoicesBy.Name = "cbFilterInvoicesBy";
            this.cbFilterInvoicesBy.Size = new System.Drawing.Size(206, 28);
            this.cbFilterInvoicesBy.TabIndex = 6;
            this.cbFilterInvoicesBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterInvoicesBy_SelectedIndexChanged);
            // 
            // txtFilterInvoicesValue
            // 
            this.txtFilterInvoicesValue.Location = new System.Drawing.Point(319, 106);
            this.txtFilterInvoicesValue.Name = "txtFilterInvoicesValue";
            this.txtFilterInvoicesValue.Size = new System.Drawing.Size(244, 27);
            this.txtFilterInvoicesValue.TabIndex = 7;
            this.txtFilterInvoicesValue.TextChanged += new System.EventHandler(this.txtFilterInvoicesValue_TextChanged);
            this.txtFilterInvoicesValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterInvoicesValue_KeyPress);
            // 
            // dtpFilterInvoicesValue
            // 
            this.dtpFilterInvoicesValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFilterInvoicesValue.Location = new System.Drawing.Point(319, 105);
            this.dtpFilterInvoicesValue.Name = "dtpFilterInvoicesValue";
            this.dtpFilterInvoicesValue.Size = new System.Drawing.Size(205, 27);
            this.dtpFilterInvoicesValue.TabIndex = 8;
            this.dtpFilterInvoicesValue.ValueChanged += new System.EventHandler(this.dtpFilterInvoicesValue_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 671);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Invoices Count:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInvoicesCount
            // 
            this.lblInvoicesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInvoicesCount.AutoSize = true;
            this.lblInvoicesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.9F, System.Drawing.FontStyle.Bold);
            this.lblInvoicesCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvoicesCount.Location = new System.Drawing.Point(142, 671);
            this.lblInvoicesCount.Name = "lblInvoicesCount";
            this.lblInvoicesCount.Size = new System.Drawing.Size(42, 23);
            this.lblInvoicesCount.TabIndex = 10;
            this.lblInvoicesCount.Text = "[##]";
            this.lblInvoicesCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(88, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "Invoices and Payments Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.invoice__5_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmInvoicesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1174, 723);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInvoicesCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFilterInvoicesValue);
            this.Controls.Add(this.txtFilterInvoicesValue);
            this.Controls.Add(this.cbFilterInvoicesBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbAllInvoices);
            this.Controls.Add(this.rbViewPendingInvoices);
            this.Controls.Add(this.dgvAllInvoices);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInvoicesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices Management";
            this.Load += new System.EventHandler(this.frmInvoicesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInvoices)).EndInit();
            this.InvoicesMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllInvoices;
        private Guna.UI.WinForms.GunaRadioButton rbViewPendingInvoices;
        private Guna.UI.WinForms.GunaRadioButton rbAllInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterInvoicesBy;
        private System.Windows.Forms.TextBox txtFilterInvoicesValue;
        private System.Windows.Forms.DateTimePicker dtpFilterInvoicesValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInvoicesCount;
        private System.Windows.Forms.ContextMenuStrip InvoicesMenu;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyDiscountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentHistorytoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payFullToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payPartialToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}