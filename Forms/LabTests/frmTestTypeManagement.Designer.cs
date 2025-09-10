namespace HospitalManagementSystem.Forms.LabTests
{
    partial class frmTestTypeManagement
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestTypeSettings = new System.Windows.Forms.DataGridView();
            this.TestTypeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llAddNewTestType = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypeSettings)).BeginInit();
            this.TestTypeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.systemLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(57)))), ((int)(((byte)(142)))));
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lab Test Type Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTestTypeSettings
            // 
            this.dgvTestTypeSettings.AllowUserToAddRows = false;
            this.dgvTestTypeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestTypeSettings.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvTestTypeSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestTypeSettings.ContextMenuStrip = this.TestTypeMenu;
            this.dgvTestTypeSettings.Location = new System.Drawing.Point(12, 134);
            this.dgvTestTypeSettings.Name = "dgvTestTypeSettings";
            this.dgvTestTypeSettings.RowHeadersVisible = false;
            this.dgvTestTypeSettings.RowHeadersWidth = 51;
            this.dgvTestTypeSettings.RowTemplate.Height = 24;
            this.dgvTestTypeSettings.Size = new System.Drawing.Size(459, 548);
            this.dgvTestTypeSettings.TabIndex = 2;
            // 
            // TestTypeMenu
            // 
            this.TestTypeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TestTypeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.activeToolStripMenuItem,
            this.deactiveToolStripMenuItem});
            this.TestTypeMenu.Name = "TestTypeMenu";
            this.TestTypeMenu.Size = new System.Drawing.Size(137, 76);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // activeToolStripMenuItem
            // 
            this.activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            this.activeToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.activeToolStripMenuItem.Text = "Active";
            this.activeToolStripMenuItem.Click += new System.EventHandler(this.activeToolStripMenuItem_Click);
            // 
            // deactiveToolStripMenuItem
            // 
            this.deactiveToolStripMenuItem.Name = "deactiveToolStripMenuItem";
            this.deactiveToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.deactiveToolStripMenuItem.Text = "Deactive";
            this.deactiveToolStripMenuItem.Click += new System.EventHandler(this.deactiveToolStripMenuItem_Click);
            // 
            // llAddNewTestType
            // 
            this.llAddNewTestType.AutoSize = true;
            this.llAddNewTestType.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llAddNewTestType.Location = new System.Drawing.Point(329, 109);
            this.llAddNewTestType.Name = "llAddNewTestType";
            this.llAddNewTestType.Size = new System.Drawing.Size(142, 20);
            this.llAddNewTestType.TabIndex = 4;
            this.llAddNewTestType.TabStop = true;
            this.llAddNewTestType.Text = "Add New Test  Type";
            this.llAddNewTestType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAddNewTestType_LinkClicked);
            // 
            // frmTestTypeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(483, 694);
            this.Controls.Add(this.llAddNewTestType);
            this.Controls.Add(this.dgvTestTypeSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTestTypeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Type Management";
            this.Load += new System.EventHandler(this.frmTestTypeManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestTypeSettings)).EndInit();
            this.TestTypeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTestTypeSettings;
        private System.Windows.Forms.ContextMenuStrip TestTypeMenu;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactiveToolStripMenuItem;
        private System.Windows.Forms.LinkLabel llAddNewTestType;
    }
}