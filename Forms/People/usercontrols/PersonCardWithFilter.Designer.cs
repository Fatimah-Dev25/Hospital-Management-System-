namespace HospitalManagementSystem.Forms.People.usercontrols
{
    partial class PersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gbFilterBy = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new Guna.UI.WinForms.GunaImageButton();
            this.btnFindPerson = new Guna.UI.WinForms.GunaImageButton();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ucPersonView1 = new HospitalManagementSystem.Forms.usercontrols.ucPersonView();
            this.gbFilterBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilterBy
            // 
            this.gbFilterBy.Controls.Add(this.btnAddPerson);
            this.gbFilterBy.Controls.Add(this.btnFindPerson);
            this.gbFilterBy.Controls.Add(this.txtFilterBy);
            this.gbFilterBy.Controls.Add(this.cbFilterBy);
            this.gbFilterBy.Controls.Add(this.label1);
            this.gbFilterBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.gbFilterBy.Location = new System.Drawing.Point(4, 5);
            this.gbFilterBy.Name = "gbFilterBy";
            this.gbFilterBy.Size = new System.Drawing.Size(730, 110);
            this.gbFilterBy.TabIndex = 1;
            this.gbFilterBy.TabStop = false;
            this.gbFilterBy.Text = "Filter";
            this.gbFilterBy.Enter += new System.EventHandler(this.gbFilterBy_Enter);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddPerson.Image = global::HospitalManagementSystem.Properties.Resources.icon2;
            this.btnAddPerson.ImageSize = new System.Drawing.Size(44, 44);
            this.btnAddPerson.Location = new System.Drawing.Point(570, 35);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.OnHoverImage = null;
            this.btnAddPerson.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnAddPerson.Size = new System.Drawing.Size(50, 50);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFindPerson.Image = global::HospitalManagementSystem.Properties.Resources.icon1;
            this.btnFindPerson.ImageSize = new System.Drawing.Size(44, 44);
            this.btnFindPerson.Location = new System.Drawing.Point(507, 35);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.OnHoverImage = null;
            this.btnFindPerson.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnFindPerson.Size = new System.Drawing.Size(50, 50);
            this.btnFindPerson.TabIndex = 2;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(275, 45);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(226, 27);
            this.txtFilterBy.TabIndex = 2;
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "Person Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(124, 44);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(145, 28);
            this.cbFilterBy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FindBy:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucPersonView1
            // 
            this.ucPersonView1.BackColor = System.Drawing.Color.White;
            this.ucPersonView1.Location = new System.Drawing.Point(4, 111);
            this.ucPersonView1.Name = "ucPersonView1";
            this.ucPersonView1.Size = new System.Drawing.Size(730, 387);
            this.ucPersonView1.TabIndex = 0;
            this.ucPersonView1.Load += new System.EventHandler(this.ucPersonView1_Load);
            // 
            // PersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.gbFilterBy);
            this.Controls.Add(this.ucPersonView1);
            this.Name = "PersonCardWithFilter";
            this.Size = new System.Drawing.Size(738, 501);
            this.Load += new System.EventHandler(this.PersonCardWithFilter_Load_1);
            this.gbFilterBy.ResumeLayout(false);
            this.gbFilterBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.usercontrols.ucPersonView ucPersonView1;
        private System.Windows.Forms.GroupBox gbFilterBy;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaImageButton btnFindPerson;
        private Guna.UI.WinForms.GunaImageButton btnAddPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
