using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.Utilities.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Doctors
{
    public partial class frmAddEditDoctor : Form
    {
        public delegate void DataBackEventHandler(object sender, int DoctorID);
        public event DataBackEventHandler DataBack;
        enum Mode { AddNew, Update};
        private Mode _mode;

        private int _DoctorID;
        private Doctor _CurrentDoctor;
        private DoctorService _DoctorService;
        private List<(int ID, string Department)> _DepartmentsList;
        public frmAddEditDoctor()
        {
            _mode = Mode.AddNew;
            _DoctorService = new DoctorService();
            InitializeComponent();
        }
        public frmAddEditDoctor(int doctorID)
        {
            _mode = Mode.Update;
            _DoctorService = new DoctorService();
            _DoctorID = doctorID;
            InitializeComponent();
        }

        private void _ResetDefaultValues()
        {
            lblDoctorID.Text = "[###]";
            txtSpecialization.Text = "";
            txtExperienceYears.Text = "";
            dtDateHired.MaxDate = DateTime.Now;
            tpAddDoctor.Enabled = false;

            if (_mode == Mode.AddNew) { 
            
                btnSave.Enabled = false;
                personCardWithFilter1.FilterEnabled = true;
                _CurrentDoctor = new Doctor();
                tpAddDoctor.Enabled = false;
            }
            else
            {
                tpAddDoctor.Enabled = true;
                btnSave.Enabled = true;
            }
           

            _FillDepartmentListInComboBox();
        }

        private void _FillDepartmentListInComboBox()
        {
            _DepartmentsList = _DoctorService.GetMedicalDepartmentsOnly();

            foreach (var item in _DepartmentsList) { 
            
                cbDepartmentsList.Items.Add(item.Department);
            }
        }

        private void _LoadData()
        {
            _CurrentDoctor = _DoctorService.GetById(_DoctorID);

            if (_CurrentDoctor == null) {

                MessageBox.Show($"There is no Doctor with ID = {_DoctorID}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            personCardWithFilter1.FilterEnabled = false;
            personCardWithFilter1.LoadPersonInfo(_CurrentDoctor.PersonID);
            tpAddDoctor.Text = "Update Doctor Info";
            tcDotorDetail.SelectedIndex = 1;
            lblDoctorID.Text = $"[{_CurrentDoctor.DoctorID}]";
            txtSpecialization.Text = _CurrentDoctor.Specialization;
            txtExperienceYears.Text = _CurrentDoctor?.ExperienceYears.ToString();
            dtDateHired.Value = _CurrentDoctor.DateHired;
            cbDepartmentsList.SelectedItem = _DepartmentsList.FirstOrDefault(Dp => Dp.ID == _CurrentDoctor.DepartmentID).Department;
            btnSave.Enabled = true;

        }

        private void frmAddEditDoctor_Load(object sender, EventArgs e)
        {
            personCardWithFilter1.FilterFocus();
            _ResetDefaultValues();

            if (_mode == Mode.Update)
                _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _ValidateForm() =>
            ValidationHelper.IsNotEmpty(txtSpecialization, errorProvider1) &&
            (ValidationHelper.IsNotEmpty(txtExperienceYears, errorProvider1) &&
            ValidationHelper.IsNumeric(txtExperienceYears, errorProvider1, "Please enter the experience in numbers only.")) &&
            !string.IsNullOrEmpty(cbDepartmentsList.Text);
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
            {
                MessageBox.Show("Please check the form. Some fields contain invalid or missing information.",
                "Form Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            _CurrentDoctor.Specialization = txtSpecialization.Text;
            _CurrentDoctor.ExperienceYears = Convert.ToInt32(txtExperienceYears.Text);
            _CurrentDoctor.DepartmentID = _DepartmentsList.FirstOrDefault(Dp => Dp.Department == cbDepartmentsList.Text).ID;
            _CurrentDoctor.DateHired = dtDateHired.Value;

            if(_mode == Mode.AddNew)
            {
                _CurrentDoctor.PersonID = personCardWithFilter1.PersonID;
                _DoctorID = _DoctorService.Add(_CurrentDoctor, Global.CurrentUser.UsertId);

                if(_DoctorID > 0)
                {
                    DataBack?.Invoke(this, _DoctorID);
                    lblDoctorID.Text = _DoctorID.ToString();
                    _mode = Mode.Update;
                    tpAddDoctor.Text = "Update Doctor Info";

                    MessageBox.Show("Doctor added successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Doctor added faild", "Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }


            }
            else
            {
                if (_DoctorService.Update(_CurrentDoctor, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("Update Doctor Successfully", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Update Doctor Failed", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Update) {

                tpAddDoctor.Enabled = true;
                btnSave.Enabled = true;
                tcDotorDetail.SelectedTab = tcDotorDetail.TabPages["tpAddDoctor"];
                return;
            }

            if(personCardWithFilter1.PersonID > 0)
            {
                if (_DoctorService.isDoctorExistsForPerson(personCardWithFilter1.PersonID))
                {
                    MessageBox.Show("This person is already registered as a Doctor or Staff.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    personCardWithFilter1.FilterFocus();
                }
                else
                {
                    tpAddDoctor.Enabled = true;
                    btnSave.Enabled = true;
                    tcDotorDetail.SelectedTab = tcDotorDetail.TabPages["tpAddDoctor"];
                }
            }
            else
            {
          
                    MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tpAddDoctor.Enabled = false;
                    personCardWithFilter1.FilterFocus();

                
            }

        }

        private void personCardWithFilter1_onPersonSelected(int obj)
        {
            _CurrentDoctor.DoctorID = obj;
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
