using HospitalManagementSystem.Forms.People;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Properties;
using HospitalManagementSystem.Services;
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

namespace HospitalManagementSystem.Forms.usercontrols
{
    public partial class ucPersonView : UserControl
    {
        private int _PersonID = -1;
        private Person _Person;
        private PersonService _PersonService;

        private Color _Color;

        public Color BackgroundColor
        {
            set
            {
                groupBox1.BackColor = value;
                _Color = value;
            }
        }
        public int PersonID
        {
            get { return _PersonID; }
        }

        public Person SelectedPerson
        {
            get { return _Person; }
        }
        public ucPersonView()
        {
            InitializeComponent();
        }

        private void ucPersonView_Load(object sender, EventArgs e)
        {
            _PersonService = new PersonService();
        }
        public void LoadPersonInControl(int personID)
        {
            _Person = _PersonService.GetById(personID);
            _PersonID = personID;

            if (_Person == null)
            {

                _ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + personID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public void LoadPersonInControl(string name)
        {
            _Person = _PersonService.GetByName(name);

            if (_Person == null) {

                _ResetPersonInfo();
                MessageBox.Show("No Person with Person Name = " + name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = _Person.PersonID;

            _FillPersonInfo();
        }

        private void _ResetPersonInfo()
        {
            lblPersonID.Text = "###";
            lblPersonName.Text = "????";
            lblEmail.Text = "???";
            lblPhone.Text = "???";
            lblAddress.Text = "???";
            lblGender.Text = "???";
            lblPersonBirthdate.Text = "??/??/????";
            pbPersonImage.Image = Resources.user1;
            llEditPerson.Enabled = false;
        }

        private void _LoadPersonImage()
        {
            string imagePath = _Person.ImagePath;
            
            if (!string.IsNullOrEmpty(imagePath))
            {
                if (File.Exists(imagePath)) { 
                
                    pbPersonImage.ImageLocation = _Person.ImagePath;
                }
                else
                {
                    MessageBox.Show($"Could not find this image: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void _FillPersonInfo()
        {
            llEditPerson.Enabled = true;
            lblPersonID.Text = _Person.PersonID.ToString();
            lblPersonName.Text = _Person.Fullname;
            lblEmail.Text = (string.IsNullOrEmpty(_Person.Email))?"": _Person.Email;
            lblPhone.Text = _Person.Phone;
            lblAddress.Text = _Person.Address;
            lblGender.Text = (_Person.Gender == Models.Enums.GenderType.Male) ? "Male" : "Female";
            lblPersonBirthdate.Text = _Person.BirthDate.ToString("dd/MMM/yyyy");
            _LoadPersonImage();
            if (string.IsNullOrEmpty(_Person.ImagePath))
                pbPersonImage.Image = Resources.user1;
            else
                pbPersonImage.ImageLocation = _Person.ImagePath;

        }

        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(_PersonID);
            frm.ShowDialog();

            LoadPersonInControl(_PersonID);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
