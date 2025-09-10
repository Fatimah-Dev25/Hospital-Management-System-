namespace HospitalManagementSystem.Forms.Doctors
{
    partial class frmDoctorsManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelDoctrosView = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDoctor = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(95, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team of Experts";
            // 
            // panelDoctrosView
            // 
            this.panelDoctrosView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDoctrosView.AutoScroll = true;
            this.panelDoctrosView.Location = new System.Drawing.Point(65, 136);
            this.panelDoctrosView.Name = "panelDoctrosView";
            this.panelDoctrosView.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.panelDoctrosView.Size = new System.Drawing.Size(1407, 672);
            this.panelDoctrosView.TabIndex = 2;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDoctor.AnimationHoverSpeed = 0.07F;
            this.btnAddDoctor.AnimationSpeed = 0.03F;
            this.btnAddDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDoctor.BaseColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddDoctor.BorderColor = System.Drawing.Color.Black;
            this.btnAddDoctor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddDoctor.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.Image = global::HospitalManagementSystem.Properties.Resources.icons8_add_32;
            this.btnAddDoctor.ImageSize = new System.Drawing.Size(32, 32);
            this.btnAddDoctor.Location = new System.Drawing.Point(1281, 47);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(155)))), ((int)(((byte)(179)))));
            this.btnAddDoctor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddDoctor.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.OnHoverImage = null;
            this.btnAddDoctor.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddDoctor.Radius = 8;
            this.btnAddDoctor.Size = new System.Drawing.Size(208, 42);
            this.btnAddDoctor.TabIndex = 3;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.doctor;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoctorsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1513, 820);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.panelDoctrosView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDoctorsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctors Management";
            this.Load += new System.EventHandler(this.frmDoctorsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelDoctrosView;
        private Guna.UI.WinForms.GunaButton btnAddDoctor;
    }
}