using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Appointments
{
    public partial class frmAddEditAppointment : Form
    {
        enum enMode { AddNew, Update }
        enMode mode = enMode.AddNew;

        private int _AppointmentID;
        private Appointment _AppointmentDetail;
        AppointmentService _AppointmentService;

        List<(int ID, string Department)> _DepartmentsList;
        List<(int ID, string Doctor, string Dept)> _DoctorsList;
       
        public frmAddEditAppointment(int patientID, int appointmentID = -1)
        {
            InitializeComponent();
            _AppointmentService = new AppointmentService();
                 
            if(appointmentID > 0)
            {
                _AppointmentID = appointmentID;
                mode = enMode.Update;

            }
            else
            {
                mode = enMode.AddNew;
                _AppointmentDetail = new Appointment();
                _AppointmentDetail.PatientID = patientID;

            }
        }

        private void frmAddEditAppointment_Load(object sender, EventArgs e)
        {
            txtFilter.Focus();
            _ResetDefaultValues();

            if (mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _AppointmentDetail = _AppointmentService.GetById((int)_AppointmentID);

            if(_AppointmentDetail == null)
            {
                MessageBox.Show("There is no appointment with ID: " + _AppointmentID , "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtFilter.Text = _AppointmentDetail.PatientFile;
            cbFilterBy.SelectedIndex = 1;
            cbFilterBy.Enabled = false;
            txtFilter.Enabled = false;

            int deptID = _DepartmentsList
                .Where(item => item.Department == _AppointmentDetail.Department)
                .Select(item => item.ID)
                .FirstOrDefault(); 
            cbDepartments.SelectedValue = deptID;

            cbDoctors.SelectedValue = _AppointmentDetail.DoctorID;
            dtpAppointmentDate.Value = _AppointmentDetail.AppointmentDate;
            cbStatus.SelectedIndex = (int)_AppointmentDetail.AppointmentStatus;
            cbAppointmentTypes.SelectedIndex = (int)_AppointmentDetail.AppointmentType;
            cbTime.Text = (DateTime.Today + _AppointmentDetail.AppointmentTime).ToString("hh:mm tt");

            if(_AppointmentDetail.Notes != null)
                txtNotes.Text = _AppointmentDetail.Notes;
        }

        private void _ResetDefaultValues()
        {
            _FillItemsInComboBox();
            
            if(mode == enMode.AddNew)
            {
                this.Text = "New Patient Appointment";
                lblAppointmentID.Text = "[###]";
                
                if(_AppointmentDetail.PatientID > 0)
                {
                    cbFilterBy.SelectedIndex = 0;
                    cbFilterBy.Enabled = false;
                    txtFilter.Text = _AppointmentDetail.PatientID.ToString();
                    txtFilter.Enabled = false;
                }
                else
                {
                    cbFilterBy.SelectedIndex = 1;
                    txtFilter.Focus();

                }
                   
                cbStatus.SelectedIndex = 0;
                cbAppointmentTypes.SelectedIndex = 3;
            }
            else
            {
                this.Text = "Update Appointment Detail";
                lblAppointmentID.Text = _AppointmentID.ToString();
                cbFilterBy.SelectedIndex = 0;
               
            }

            if (cbDoctors.SelectedItem != null && dtpAppointmentDate.Value != null) {

                int doctorID = Convert.ToInt32(cbDoctors.SelectedValue);
                _LoadAvailableSlots(doctorID, dtpAppointmentDate.Value.Date);

            }

        }

        private void _FillItemsInComboBox()
        {
            _DepartmentsList = _AppointmentService.GetDepartments();
            _DoctorsList = _AppointmentService.GetAllDoctors();

            //Data Binding
            cbDepartments.DataSource = _DepartmentsList.Select(item => new { item.ID, item.Department }).ToList();

            cbDepartments.DisplayMember = "Department";
            cbDepartments.ValueMember = "ID";

            
            cbStatus.Items.AddRange(
                new string[] { "Schedule", "Confirm", "Cancel", "Complete" }
                );
            cbStatus.SelectedIndex = 0;

            cbAppointmentTypes.Items.AddRange(
                  new string[] { "Consultation", "Follow_up", "LabTest", "GeneralVisit" }
                  );
            cbAppointmentTypes.SelectedIndex = 0;
         

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbDepartments.SelectedValue == null) {

                cbDoctors.Items.Clear();
                return;
            }

            string selectedDept = cbDepartments.Text;
            var filteredDoctors = _DoctorsList
                  .Where(record => record.Dept == selectedDept)
                  .Select(record => new { record.ID, record.Doctor, record.Dept })
                  .ToList();
            
            cbDoctors.Text = "";
            cbDoctors.DataSource = filteredDoctors; 
            cbDoctors.DisplayMember = "Doctor";
            cbDoctors.ValueMember = "ID";
        }
        private void _LoadAvailableSlots(int doctorId, DateTime selectedDate)
        {
            string[] allSlots = new string[] {
               "09:00 AM", "09:30 AM", "10:00 AM", "10:30 AM",
                "11:00 AM", "11:30 AM", "12:00 PM", "12:30 PM",
                "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM"
           };

            List<string> rawBookedSlots = _AppointmentService.GetBookedSlots(doctorId, selectedDate);
            List<string> bookedSlots = rawBookedSlots
              .Select(t => DateTime.Parse(t).ToString("hh:mm tt"))
              .ToList();

            var availableSlots = allSlots.Except(bookedSlots).ToList();

            cbTime.Items.Clear();
            cbTime.Items.AddRange(availableSlots.ToArray());
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtpAppointmentDate.Value != null) {
            
                int doctorID = Convert.ToInt32(cbDoctors.SelectedValue);
                _LoadAvailableSlots(doctorID, dtpAppointmentDate.Value);
            }
        }

        private bool _ValidateRelatedPatient()
        {
            if(mode == enMode.AddNew && _AppointmentDetail.PatientID == 0)
            {

                int patientID = Convert.ToInt32(txtFilter.Text);
                _AppointmentDetail.PatientID = (cbFilterBy.SelectedIndex == 0) ?
                    _AppointmentService.isPersonExits(patientID, null) :
                    _AppointmentService.isPersonExits(0, txtFilter.Text);

                if (_AppointmentDetail.PatientID > 0) return true;
                else
                {
                    ValidationHelper.IsNotEmpty(txtFilter, errorProvider1, "this patient isn't exists, choose another one.");
                    txtFilter.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool _ValidateComboBoxex() =>
            !string.IsNullOrEmpty(cbDepartments.Text) &&
            !string.IsNullOrEmpty(cbDoctors.Text) &&
            !string.IsNullOrEmpty(cbAppointmentTypes.Text) &&
            !string.IsNullOrEmpty(cbStatus.Text) &&
            !string.IsNullOrEmpty(cbTime.Text) &&
            dtpAppointmentDate.Value.Date >= DateTime.Now.Date;

        private bool _ValidateForm()
        {
            if(!_ValidateRelatedPatient() || !_ValidateComboBoxex())
            {
                MessageBox.Show("Please check the form. Some fields contain invalid or missing information.",
                         "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _MapFormToAppointment()
        {
            if (_AppointmentDetail.PatientID == 0)
                _AppointmentDetail.PatientID = Convert.ToInt32(txtFilter.Text);

            _AppointmentDetail.Notes = txtNotes.Text;
            _AppointmentDetail.AppointmentDate = dtpAppointmentDate.Value;

            if (!string.IsNullOrEmpty(cbTime.Text))
            {
                DateTime timeValue;
                bool isParse = DateTime.TryParseExact(
                    cbTime.Text.Trim(), new [] { "hh:mm tt" , "h:mm tt"},
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out timeValue);
                
                if (isParse) _AppointmentDetail.AppointmentTime = timeValue.TimeOfDay;
            }

            _AppointmentDetail.DoctorID = Convert.ToInt32(cbDoctors.SelectedValue);
            _AppointmentDetail.AppointmentStatus = (AppointmentStatus)cbStatus.SelectedIndex;
            _AppointmentDetail.AppointmentType = (AppointmentType)cbAppointmentTypes.SelectedIndex;
            _AppointmentDetail.CreatedByUserID = Global.CurrentUser.UsertId;
        }

        private void _SaveAppointment()
        {
            if (mode == enMode.AddNew)
            {
                _AppointmentDetail.AppointementID = _AppointmentService.Add(_AppointmentDetail);
                if (_AppointmentDetail.AppointementID > 0)
                {
                    lblAppointmentID.Text = _AppointmentDetail.AppointementID.ToString();
                    mode = enMode.Update;
                    this.Text = "Update Appointment Detail";
                    MessageBox.Show("The appointment was scheduled successfully!", "Done",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to schedule the appointment. Please try again or contact support.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_AppointmentService.Update(_AppointmentDetail, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("Appointment updated successfully!", "Updated",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Appointment update failed!", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!_ValidateForm())
                return;

            _MapFormToAppointment();
            _SaveAppointment();
        }

       

        private void dtpAppointmentDate_ValueChanged_1(object sender, EventArgs e)
        {
            int docrorID = Convert.ToInt32(cbDoctors.SelectedValue);
            _LoadAvailableSlots(docrorID, dtpAppointmentDate.Value);

        }
    }
}
