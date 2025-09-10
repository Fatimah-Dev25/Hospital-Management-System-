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

namespace HospitalManagementSystem.Forms.MedicalRecords
{
    public partial class frmAddUpdateRecordInfo : Form
    {
        enum Mode { Add, Update }
        public delegate void ONRecordCreated(object sender, int recordId);
        public event ONRecordCreated RecordCreated;

        private int _RecordID;
        private int _AppointmentID;

        MedicalRecordService recordService;
        MedicalRecord _MedicalRecordEntity;
        Mode _CurrentMode;
        string _PatientName;
        public frmAddUpdateRecordInfo(int appointmentID, int patientID, int doctorID, string patientName)
        {
            InitializeComponent();

            _CurrentMode = Mode.Add;
            _MedicalRecordEntity = new MedicalRecord();
            _MedicalRecordEntity.PatientID = patientID;
            _MedicalRecordEntity.DoctorID = doctorID;
            _AppointmentID = appointmentID;
            _PatientName = patientName;
        }

        public frmAddUpdateRecordInfo(int recordID, string patientName)
        {
            InitializeComponent();
        
            _CurrentMode= Mode.Update;
            _RecordID = recordID;
            _PatientName = patientName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateRecordInfo_Load(object sender, EventArgs e)
        {
            recordService = new MedicalRecordService();

            _ResetDefaultValues();

            if (_CurrentMode == Mode.Update)
                _LoadData();

                    
        }

        private void _LoadData()
        {
            _MedicalRecordEntity = recordService.GetById(_RecordID);

            if( _MedicalRecordEntity == null)
            {
                MessageBox.Show($"There is no record with this id = {_RecordID}...","Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtDiagnosis.Text = _MedicalRecordEntity.Diagnosis;
            txtTreatment.Text = _MedicalRecordEntity.Treatment;

            if(_MedicalRecordEntity != null)
                txtNotes.Text = _MedicalRecordEntity.Notes;
        }

        private void _ResetDefaultValues()
        {
            lblPatientName.Text = _PatientName;
            txtDiagnosis.Text = "";
            txtNotes.Text = "";
            txtTreatment.Text = "";

        }
        private bool _ValidateForm()
        {
            return ValidationHelper.IsNotEmpty(txtDiagnosis, errorProvider1) &&
                ValidationHelper.IsNotEmpty(txtTreatment, errorProvider1);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm()) { 
            }

            _MedicalRecordEntity.Diagnosis = txtDiagnosis.Text;
            _MedicalRecordEntity.Treatment = txtTreatment.Text;
            _MedicalRecordEntity.CreatedByUserID = Global.CurrentUser.UsertId;
            
            if(!string.IsNullOrEmpty(txtNotes.Text))
            {
                _MedicalRecordEntity.Notes = txtNotes.Text;
            }

            if(_CurrentMode == Mode.Add)
            {
                recordService = new MedicalRecordService();
                _MedicalRecordEntity.RecordID = recordService.IssueRecord(_MedicalRecordEntity, _AppointmentID);

                if(_MedicalRecordEntity.RecordID > 0)
                {
                    MessageBox.Show("Record created Successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Record created Failed", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (recordService.Update(_MedicalRecordEntity, Global.CurrentUser.UsertId))
                {

                    MessageBox.Show("Record updated Successfully", "Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Record updated Failed", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
