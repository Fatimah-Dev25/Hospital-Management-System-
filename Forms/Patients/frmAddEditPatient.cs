using DocumentFormat.OpenXml.Spreadsheet;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Patients
{
    public partial class frmAddEditPatient : Form
    {
        enum Mode
        {
            AddNew,
            Update
        }

        IBloodTypeService bloodTypeService;
        List<(int ID, string Name)> bloodTypesList;
        private Mode _Mode;

        private int _PatientID;

        private Patient _Patient;

        private PatientService _PatientService;
        public frmAddEditPatient()
        {
            InitializeComponent();
            _Mode = Mode.AddNew;
        }

        public frmAddEditPatient(int patientID)
        {
            _Mode = Mode.Update;
            _PatientID = patientID;
            InitializeComponent();

        }

        private void _FillBloodTypesInComboBox()
        {
            bloodTypeService = new BloodTypeService();
            bloodTypesList = bloodTypeService.GetAllBloodTypes();

            foreach (var type in bloodTypesList)
            {

                cbBloodType.Items.Add(type.Name);
            }
        }
        private void _ResetDefaultValues()
        {


            if (_Mode == Mode.AddNew)
            {
                lblTitle.Text = "New Patient Registration";
                tpAddPatient.Enabled = false;
                btnSave.Enabled = false;
                personCardWithFilter1.FilterEnabled = true;
                _Patient = new Patient();

            }
            else
            {
                lblTitle.Text = "Update Patient Info";
                tpAddPatient.Enabled = true;
                btnSave.Enabled = true;
            }

            lblPatientID.Text = "[###]";
            lblFileNumber.Text = "????";
            txtAllergies.Text = "";
            txtChronicDiseases.Text = "";
            cbAdmissionStatus.SelectedIndex = 1;

            _FillBloodTypesInComboBox();

        }

        private void _LoadData()
        {

            _Patient = _PatientService.GetById(_PatientID);
            personCardWithFilter1.FilterEnabled = false;

            if (_Patient == null)
            {
                MessageBox.Show("No Patient with ID = " + _PatientID, "Patient Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            tcPatientInfo.SelectedTab = tcPatientInfo.TabPages["tpAddPatient"];
            lblPatientID.Text = _Patient.PatientId.ToString();
            lblFileNumber.Text = _Patient.FileNumber;
            txtAllergies.Text = _Patient.Allergies;
            txtChronicDiseases.Text = _Patient.ChronicDiseases;
            cbAdmissionStatus.Text = _Patient.Status.ToString();
            cbBloodType.Text = _Patient.BloodTypeName;

        }
        private void frmAddEditPatient_Load(object sender, EventArgs e)
        {
            _PatientService = new PatientService();
            _ResetDefaultValues();

            if (_Mode == Mode.Update)
                _LoadData();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string _GenerateFileNumber(int personID)
        {
            return personID.ToString("D6");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbAdmissionStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select addmission status from the list.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            if(cbBloodType.SelectedItem == null)
            {
                MessageBox.Show("Please select a blood type.", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            } 
            _Patient.Allergies = txtAllergies.Text;
            _Patient.ChronicDiseases = txtChronicDiseases.Text;
            _Patient.Status = (Models.Enums.AdmissionStatus)(cbAdmissionStatus.SelectedIndex + 1);
            _Patient.BloodTypeID = bloodTypesList.FirstOrDefault(item => item.Name == cbBloodType.Text).ID;

            if (_Mode == Mode.AddNew)
            {
                _Patient.PersonID = personCardWithFilter1.PersonID;
                _Patient.FileNumber = _GenerateFileNumber(personCardWithFilter1.PersonID);

                _PatientID = _PatientService.Add(_Patient, Global.CurrentUser.UsertId);
                if (_PatientID != 0)
                {
                    lblPatientID.Text = _PatientID.ToString();
                    lblFileNumber.Text = _Patient.FileNumber;
                    lblTitle.Text = "Update Patient Info";
                    _Mode = Mode.Update;
                    MessageBox.Show("Patient registration successful.", "Regestration", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Patient registration failed.", "Regestration", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                }


            }
            else
            {
                if (_PatientService.Update(_Patient, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("Patient Info Update successful.", "Regestration", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Patient Info Update failed.", "Regestration", MessageBoxButtons.OK,
                                           MessageBoxIcon.Error);
                }
            }


        }

        private void btnNextToDetails_Click_1(object sender, EventArgs e)
        {
            if (_Mode == Mode.Update)
            {
                btnSave.Enabled = true;
                tpAddPatient.Enabled = true;
                tcPatientInfo.SelectedTab = tcPatientInfo.TabPages["tpAddPatient"];
                return;
            }

            if (personCardWithFilter1.PersonID != 0)
            {
                if (_PatientService.CheckIfPatientExists(personCardWithFilter1.PersonID))
                {
                    MessageBox.Show("This person is already registered as a patient.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    personCardWithFilter1.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpAddPatient.Enabled = true;
                    tcPatientInfo.SelectedTab = tcPatientInfo.TabPages["tpAddPatient"];
                }
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tpAddPatient.Enabled = false;
                personCardWithFilter1.FilterFocus();

            }
        }

        private void personCardWithFilter1_onPersonSelected(int obj)
        {
            _Patient.PersonID = obj;
        }
    }
}
