namespace HospitalManagementSystem.Forms.Staff
{
    partial class frmAddUpdateEmployee
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.tcEmployeeInfo = new System.Windows.Forms.TabControl();
            this.tpSelectPerson = new System.Windows.Forms.TabPage();
            this.personCardWithFilter1 = new HospitalManagementSystem.Forms.People.usercontrols.PersonCardWithFilter();
            this.tpEmployeeDetail = new System.Windows.Forms.TabPage();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.cbShifType = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcEmployeeInfo.SuspendLayout();
            this.tpSelectPerson.SuspendLayout();
            this.tpEmployeeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.lblFormTitle.Location = new System.Drawing.Point(122, 18);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(429, 46);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Form Title";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label2.Location = new System.Drawing.Point(0, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(687, 2);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employee ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmployeeID.Location = new System.Drawing.Point(138, 98);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(133, 31);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "[###]";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcEmployeeInfo
            // 
            this.tcEmployeeInfo.Controls.Add(this.tpSelectPerson);
            this.tcEmployeeInfo.Controls.Add(this.tpEmployeeDetail);
            this.tcEmployeeInfo.Location = new System.Drawing.Point(12, 147);
            this.tcEmployeeInfo.Name = "tcEmployeeInfo";
            this.tcEmployeeInfo.SelectedIndex = 0;
            this.tcEmployeeInfo.Size = new System.Drawing.Size(666, 511);
            this.tcEmployeeInfo.TabIndex = 5;
            // 
            // tpSelectPerson
            // 
            this.tpSelectPerson.Controls.Add(this.personCardWithFilter1);
            this.tpSelectPerson.Location = new System.Drawing.Point(4, 29);
            this.tpSelectPerson.Name = "tpSelectPerson";
            this.tpSelectPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tpSelectPerson.Size = new System.Drawing.Size(658, 478);
            this.tpSelectPerson.TabIndex = 0;
            this.tpSelectPerson.Text = "Select Person";
            this.tpSelectPerson.UseVisualStyleBackColor = true;
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.personCardWithFilter1.FilterEnabled = true;
            this.personCardWithFilter1.Location = new System.Drawing.Point(7, 4);
            this.personCardWithFilter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.ShowAddPerson = true;
            this.personCardWithFilter1.Size = new System.Drawing.Size(648, 470);
            this.personCardWithFilter1.TabIndex = 0;
            this.personCardWithFilter1.onPersonSelected += new System.Action<int>(this.personCardWithFilter1_onPersonSelected);
            // 
            // tpEmployeeDetail
            // 
            this.tpEmployeeDetail.Controls.Add(this.rbActive);
            this.tpEmployeeDetail.Controls.Add(this.cbDepartments);
            this.tpEmployeeDetail.Controls.Add(this.dtpHireDate);
            this.tpEmployeeDetail.Controls.Add(this.cbShifType);
            this.tpEmployeeDetail.Controls.Add(this.txtPosition);
            this.tpEmployeeDetail.Controls.Add(this.btnSave);
            this.tpEmployeeDetail.Controls.Add(this.label8);
            this.tpEmployeeDetail.Controls.Add(this.label7);
            this.tpEmployeeDetail.Controls.Add(this.label6);
            this.tpEmployeeDetail.Controls.Add(this.label5);
            this.tpEmployeeDetail.Controls.Add(this.label4);
            this.tpEmployeeDetail.Location = new System.Drawing.Point(4, 29);
            this.tpEmployeeDetail.Name = "tpEmployeeDetail";
            this.tpEmployeeDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmployeeDetail.Size = new System.Drawing.Size(658, 478);
            this.tpEmployeeDetail.TabIndex = 1;
            this.tpEmployeeDetail.Text = "Employee Detail";
            this.tpEmployeeDetail.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Segoe UI", 9.9F);
            this.rbActive.Location = new System.Drawing.Point(172, 306);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(77, 27);
            this.rbActive.TabIndex = 14;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(172, 239);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(272, 28);
            this.cbDepartments.TabIndex = 13;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(172, 170);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(225, 27);
            this.dtpHireDate.TabIndex = 12;
            // 
            // cbShifType
            // 
            this.cbShifType.FormattingEnabled = true;
            this.cbShifType.Items.AddRange(new object[] {
            "None",
            "Morning",
            "Evening",
            "Night"});
            this.cbShifType.Location = new System.Drawing.Point(172, 107);
            this.cbShifType.Name = "cbShifType";
            this.cbShifType.Size = new System.Drawing.Size(272, 28);
            this.cbShifType.TabIndex = 11;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(172, 42);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(404, 27);
            this.txtPosition.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::HospitalManagementSystem.Properties.Resources.icons8_save_321;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(465, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 8;
            this.btnSave.Size = new System.Drawing.Size(160, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label8.Location = new System.Drawing.Point(39, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "is Active? ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label7.Location = new System.Drawing.Point(39, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Department:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label6.Location = new System.Drawing.Point(39, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hire Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(39, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Shift Type:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.label4.Location = new System.Drawing.Point(39, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HospitalManagementSystem.Properties.Resources.new_employee;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 670);
            this.Controls.Add(this.tcEmployeeInfo);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateEmployee";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.tcEmployeeInfo.ResumeLayout(false);
            this.tpSelectPerson.ResumeLayout(false);
            this.tpEmployeeDetail.ResumeLayout(false);
            this.tpEmployeeDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TabControl tcEmployeeInfo;
        private System.Windows.Forms.TabPage tpSelectPerson;
        private People.usercontrols.PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.TabPage tpEmployeeDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.ComboBox cbShifType;
        private System.Windows.Forms.TextBox txtPosition;
        private Guna.UI.WinForms.GunaButton btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}