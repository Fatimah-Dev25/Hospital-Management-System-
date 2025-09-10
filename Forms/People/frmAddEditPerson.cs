using HospitalManagementSystem.Models;
using HospitalManagementSystem.Properties;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.People
{
    public partial class frmAddEditPerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;

        enum enMode { AddNew, Update }
        private int _PersonID = 0;
        private Person _Person;
        private PersonService _PersonService;
        enMode CurrentMode;
        private string _OriginalImagePath;
        public frmAddEditPerson()
        {
            CurrentMode = enMode.AddNew;
            InitializeComponent();
        }
        public frmAddEditPerson(int personID)
        {
            _PersonID = personID;
            InitializeComponent();
            CurrentMode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            lblPersonID.Text = "###";
            txtFullname.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            rbMale.Checked = true;
            dtpBirthDate.MaxDate = DateTime.Now;
            pbPersonImage.Image = Resources.add_user__1_;
            _OriginalImagePath = null;

            if (CurrentMode == enMode.AddNew)
            {
                this.Text = "Add Person";
                _Person = new Person();
            }
            else
            {
                this.Text = "Update Person Info";
            }
            llRemoveImg.Visible = pbPersonImage.ImageLocation != null;
        }
        private void _LoadData()
        {
            _Person = _PersonService.GetById(_PersonID);

            if (_Person != null)
            {


                lblPersonID.Text = _Person.PersonID.ToString();
                txtFullname.Text = _Person.Fullname;
                txtEmail.Text = _Person.Email;
                txtPhone.Text = _Person.Phone;
                txtAddress.Text = _Person.Address;
                dtpBirthDate.Value = _Person.BirthDate;

                if (_Person.Gender == Models.Enums.GenderType.Male) rbMale.Checked = true;
                else rbFemale.Checked = true;
                               

                if (!String.IsNullOrEmpty(_Person.ImagePath))
                {
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                    _OriginalImagePath = _Person.ImagePath;
                }
                else
                {
                    _OriginalImagePath = null;
                }

                llRemoveImg.Visible = pbPersonImage.ImageLocation != null;
            }
            else
            {
                MessageBox.Show($"There is no person with ID: {_PersonID}", "Not Exists!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void frmAddEditPerson_Load_1(object sender, EventArgs e)
        {
            _PersonService = new PersonService();
            _ResetDefaultValues();

            if (CurrentMode == enMode.Update)
                _LoadData();
        }
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImage.ImageLocation = selectedFilePath;
                llRemoveImg.Visible = true;

            }
        }
        private void llRemoveImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImage.ImageLocation = null;

            pbPersonImage.Image = Resources.add_user__1_;

            llRemoveImg.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _HandlePersonImg()
        {
            if (_OriginalImagePath != pbPersonImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);

                    }
                    catch (IOException)
                    {

                    }

                }

                if (pbPersonImage.ImageLocation != null)
                {
                    string sourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (Util.copyImageToProjectImagesFolder(ref sourceImageFile))
                    {
                        pbPersonImage.ImageLocation = sourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
            {
                MessageBox.Show("Some Fileds are not valide!, put mouse over red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            if (!_HandlePersonImg())
                return;

            _Person.Fullname = txtFullname.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Email = txtEmail.Text;
            _Person.Address = txtAddress.Text;
            _Person.Gender = rbMale.Checked?Models.Enums.GenderType.Male:Models.Enums.GenderType.Female;
            _Person.BirthDate = dtpBirthDate.Value;
            _Person.ImagePath = pbPersonImage.ImageLocation != null ? pbPersonImage.ImageLocation : null;

            switch (CurrentMode)
            {
                case enMode.AddNew:
                    {
                        if((_PersonID = _PersonService.Add(_Person, Global.CurrentUser.UsertId)) != 0)
                        {
                            this.Text = "Update Person Info";
                            lblPersonID.Text = _PersonID.ToString();
                            CurrentMode = enMode.Update;
                            MessageBox.Show("Person Added Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataBack?.Invoke(this, _PersonID);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while adding the person.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    }
                    case enMode.Update: {

                        if (_PersonService.Update(_Person, Global.CurrentUser.UsertId))
                        {
                            MessageBox.Show("Person Updated Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Person Updated Faild.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        break;
                    }
            }

        }

        private bool _ValidateForm()
        {
            return ValidationHelper.IsNotEmpty(txtFullname, errorProvider1) &&
                   ValidationHelper.IsNotEmpty(txtPhone, errorProvider1) &&
                   ValidationHelper.IsNumeric(txtPhone, errorProvider1) &&
                   (string.IsNullOrWhiteSpace(txtEmail.Text) || ValidationHelper.IsValidEmail(txtEmail, errorProvider1)) &&
                   ValidationHelper.IsNotEmpty(txtAddress, errorProvider1);
        }
    }
}
