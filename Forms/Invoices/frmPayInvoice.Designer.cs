namespace HospitalManagementSystem.Forms.Invoices
{
    partial class frmPayInvoice
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
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPayInvoice = new Guna.UI.WinForms.GunaButton();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice ID:";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInvoiceID.ForeColor = System.Drawing.Color.Red;
            this.lblInvoiceID.Location = new System.Drawing.Point(135, 30);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(33, 20);
            this.lblInvoiceID.TabIndex = 1;
            this.lblInvoiceID.Text = "[??]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(75, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Status:";
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.AutoSize = true;
            this.lblInvoiceStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInvoiceStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceStatus.Location = new System.Drawing.Point(135, 121);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(44, 20);
            this.lblInvoiceStatus.TabIndex = 3;
            this.lblInvoiceStatus.Text = "?????";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(33, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pay Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount To Pay:";
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card",
            "Prepaid Card",
            "Bank Transfer",
            "E-Wallets"});
            this.cbPayMethod.Location = new System.Drawing.Point(139, 165);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(166, 28);
            this.cbPayMethod.TabIndex = 6;
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(139, 213);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(120, 27);
            this.txtAmountToPay.TabIndex = 7;
            this.txtAmountToPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountToPay_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(261, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "aed.";
            // 
            // btnPayInvoice
            // 
            this.btnPayInvoice.AnimationHoverSpeed = 0.07F;
            this.btnPayInvoice.AnimationSpeed = 0.03F;
            this.btnPayInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnPayInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPayInvoice.BorderColor = System.Drawing.Color.Black;
            this.btnPayInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPayInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.btnPayInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 8.6F, System.Drawing.FontStyle.Bold);
            this.btnPayInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPayInvoice.Image = null;
            this.btnPayInvoice.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPayInvoice.Location = new System.Drawing.Point(174, 275);
            this.btnPayInvoice.Name = "btnPayInvoice";
            this.btnPayInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPayInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPayInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPayInvoice.OnHoverImage = null;
            this.btnPayInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.btnPayInvoice.Radius = 8;
            this.btnPayInvoice.Size = new System.Drawing.Size(160, 38);
            this.btnPayInvoice.TabIndex = 9;
            this.btnPayInvoice.Text = "Make Payment";
            this.btnPayInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPayInvoice.Click += new System.EventHandler(this.btnPayInvoice_Click);
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInvoiceAmount.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceAmount.ForeColor = System.Drawing.Color.Red;
            this.lblInvoiceAmount.Location = new System.Drawing.Point(135, 76);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(35, 20);
            this.lblInvoiceAmount.TabIndex = 11;
            this.lblInvoiceAmount.Text = "[??]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(24, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Amount:";
            // 
            // frmPayInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(346, 325);
            this.Controls.Add(this.lblInvoiceAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPayInvoice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.cbPayMethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInvoiceStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInvoiceID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPayInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pay Invoice";
            this.Load += new System.EventHandler(this.frmPayInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInvoiceStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPayMethod;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton btnPayInvoice;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.Label label7;
    }
}