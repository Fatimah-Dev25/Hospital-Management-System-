using HospitalManagementSystem.Forms.Appointments;
using HospitalManagementSystem.Forms.Billings;
using HospitalManagementSystem.Forms.LabTests;
using HospitalManagementSystem.Forms.MedicalRecords;
using HospitalManagementSystem.Forms.Prescriptions;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
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
    public partial class frmPatientDetail : Form
    {
        PatientService patientService;
        AppointmentService appointmentService;
        MedicalRecordService recordService;
        PrescriptionService prescriptionService;
        LabTestService labTestService;

        Patient _Patient;
        private int _PatientID;


        private DataTable _PatientAppointments;
        public frmPatientDetail(int patientID)
        {
            InitializeComponent();
            _PatientID = patientID;
        }

        private void _FillBasicPatientInfo()
        {
            lblPatientID.Text = _Patient.PatientId.ToString();
            lblFullname.Text = _Patient.RelatedPerson.Fullname;
            lblFileNumber.Text = _Patient.FileNumber;
            lblPhone.Text = _Patient.RelatedPerson.Phone;
            lblBirthdate.Text = _Patient.RelatedPerson.BirthDate.ToString("MMM, dd/yyyy");
            lblGender.Text = _Patient.RelatedPerson.Gender == Models.Enums.GenderType.Male ? "Male" : "Female";
            lblAllergies.Text = _Patient.Allergies;
            lblAddmissionType.Text = _Patient.Status.ToString();
            lblBloodType.Text = _Patient.BloodTypeName;
            lblDiseases.Text = _Patient.ChronicDiseases;
          
        }
        private void frmShowPatientDetail_Load(object sender, EventArgs e)
        {
            InitializeServices();
            
            _Patient = patientService.GetById(_PatientID);
            _PatientAppointments = appointmentService.GetAppointmentsFiltered(null, null, null, _PatientID);


            if (_Patient != null)
            {
                _FillBasicPatientInfo();
            }
            else
            {
                MessageBox.Show($"There is no patient with ID: {_PatientID}", "Not Exists"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error );
            }


        }

        private void InitializeServices()
        {
            patientService = new PatientService();
            appointmentService = new AppointmentService();
            recordService = new MedicalRecordService();
            prescriptionService = new PrescriptionService();
            labTestService = new LabTestService();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void llEditPatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPatient frm = new frmAddEditPatient(_PatientID);
            frm.ShowDialog();

            _Patient = patientService.GetById(_PatientID);
            _FillBasicPatientInfo();
        }

        private void btnAddApointment_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.AppointmentsPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            var frm = new frmAddEditAppointment(_PatientID);
            frm.ShowDialog();

            _LoadAppointmentsDetails();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex) { 
            
                case 0:
                    {
                        break;
                    }

                case 1:
                    {
                        _LoadAppointmentsDetails();
                        break;
                    }
                
                case 2:
                    {
                        _LoadRecordsDetail();
                        
                        break;
                    }

                case 3:
                    {
                        _LoadLabTestsDetail();
                        break;
                    }

                case 4:
                    {
                        _LoadPrescriptionsDetail();
                        break;
                    }


                default:
                    {
                        break;
                    }
            }
        }

        private void _LoadLabTestsDetail()
        {
            var testsList = labTestService.GetLabTestsListFilterd(null, _PatientID);
            dgvPatientTests.DataSource = testsList;
            dgvPatientTests.Columns["LabTestConfirmed"].Visible = false;
            lblTestsCount.Text = dgvPatientTests.Rows.Count.ToString();

            foreach (DataGridViewRow row in dgvPatientTests.Rows)
            {
                if (Convert.ToInt32(row.Cells["LabTestConfirmed"].Value) == 1)
                {
                    toolUpdateLabTest.Enabled = false;
                    toolDeleteLabTest.Enabled = false;

                }

            }
        }

        private void _LoadPrescriptionsDetail()
        {
            var prescriptionsList = prescriptionService.GetPrescriptionsByPatientID(_PatientID);
            dgvPatientPrescriptions.DataSource = prescriptionsList;
            dgvPatientPrescriptions.Columns["PaidPrescription"].Visible = false;
            lblPrescriptionsCount.Text = dgvPatientPrescriptions.Rows.Count.ToString();

            foreach (DataGridViewRow row in dgvPatientPrescriptions.Rows)
            {
                if (Convert.ToInt32(row.Cells["PaidPrescription"].Value) == 1)
                {
                    toolUpdatePatientPrescription.Enabled = false;
                    toolDeletePrescription.Enabled = false;

                }
            
            }
        }

        private bool _CheckActiveAppointment(DataGridViewRow recordRow)
        {
            int recordId = Convert.ToInt32(recordRow.Cells["RecordID"].Value);

            var appointments = _PatientAppointments.AsEnumerable()
                .Where(r => r.Field<int>("RecordID") == recordId);

            bool hasComplete = appointments.Any(r =>
                string.Equals(r.Field<string>("AppointmentStatus"), "Complete", StringComparison.OrdinalIgnoreCase));

            return hasComplete;
        }

        private void _LoadRecordsDetail()
        {
            var allRecords = recordService.GetPatientRecords(_PatientID);
            dgvPatientRecords.DataSource = allRecords;
            lblRecordsNumber.Text = dgvPatientRecords.Rows.Count.ToString();

            foreach (DataGridViewRow row in dgvPatientRecords.Rows)
            {
                if (row.Cells["IsDeleted"].Value != null && Convert.ToBoolean(row.Cells["IsDeleted"].Value) == true)
                {
                    row.ReadOnly = true;

                    row.DefaultCellStyle.BackColor = Color.LightGray;

                    row.ContextMenuStrip = null;
                }
                //if (_CheckActiveAppointment(row)) {
                
                //    toolAddLabTest.Enabled = false;
                //    toolIssuePrescription.Enabled = false;
                //}
            }
        }

        private void _FormatAppointmentGrid()
        {
            if (dgvPatientAppointments.Rows.Count > 0)
            {
                dgvPatientAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvPatientAppointments.Columns["DoctorID"].Visible = false;
                dgvPatientAppointments.Columns["FileNumber"].Visible = false;
                dgvPatientAppointments.Columns["PatientAge"].Visible = false;
                dgvPatientAppointments.Columns["PatientName"].Visible = false;
                dgvPatientAppointments.Columns["RecordID"].Visible = false;
                dgvPatientAppointments.Columns["DoctorName"].Width = 150;
                dgvPatientAppointments.Columns["AppointmentType"].Width = 130;

              
            }
        }
        private void _LoadAppointmentsDetails()
        {
            dgvPatientAppointments.DataSource = _PatientAppointments;
           _FormatAppointmentGrid();
        }

        private void updateAppointment_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;
            }


            int appointmentID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells[0].Value);
            frmAddEditAppointment frm = new frmAddEditAppointment(_PatientID, appointmentID);
            frm.ShowDialog();

        }

        private void AppointmentConfirm_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int appointmentID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells[0].Value);
            
            if(appointmentService.UpdateAppointmentStatus(appointmentID, AppointmentStatus.Confirm, Global.CurrentUser.UsertId))
            {
                MessageBox.Show("Appointment has Confirmed Successfully.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {

                MessageBox.Show("Appointment Confirmed Failed.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentComplete_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int appointmentID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells[0].Value);

            if (appointmentService.UpdateAppointmentStatus(appointmentID, AppointmentStatus.Complete, Global.CurrentUser.UsertId))
            {
                MessageBox.Show("Appointment has Completed Successfully.",
                    "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {

                MessageBox.Show("Appointment Completed Failed.",
                    "Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentCancel_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int appointmentID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells[0].Value);

            if (appointmentService.UpdateAppointmentStatus(appointmentID, AppointmentStatus.Cancel, Global.CurrentUser.UsertId))
            {
                MessageBox.Show("Appointment has Canceled Successfully.",
                    "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {

                MessageBox.Show("Appointment Canceled Failed.",
                    "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteAppointment_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Delete))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int appointmentID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells[0].Value);
           
           if(MessageBox.Show("Are you sure to delete this appointment?","Delete", 
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (appointmentService.Delete(appointmentID, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("Appointment Deleted Successfully.",
                        "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    _LoadAppointmentsDetails();
                }
                else
                {

                    MessageBox.Show("Appointment Deleted Failed.",
                        "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void issueNewRecord_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int appointmentID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells[0].Value);
            int doctorID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells["DoctorID"].Value);

            var frm = new frmAddUpdateRecordInfo(appointmentID, _PatientID, doctorID,lblFullname.Text);
            frm.ShowDialog();
        }


        private void linkAppointmentToRecord_Click(object sender, EventArgs e)
        {
            int appointmentID = Convert.ToInt32(dgvPatientAppointments.CurrentRow.Cells[0].Value);
            var frm = new frmLinkRecordToAppointment(appointmentID);
            frm.ShowDialog();
        }

        private void dtpFilterByDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpFilterByDate.Value.Date;

            DataView dv = _PatientAppointments.DefaultView;
            dv.RowFilter = $"AppointmentDate = #{selectedDate.ToString("MM/dd/yyyy")}#";
            dgvPatientAppointments.DataSource = dv;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _LoadAppointmentsDetails();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Delete))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }


            int recordId = Convert.ToInt32(dgvPatientRecords.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure to delete this record?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (recordService.Delete(recordId, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("Record Deleted successfully", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record can't delete, this record link to other infromation",
                        "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolUpdate_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int recordId = Convert.ToInt32(dgvPatientRecords.CurrentRow.Cells[0].Value);

            var frm = new frmAddUpdateRecordInfo(recordId, lblFullname.Text);
            frm.ShowDialog();

        }

        private void toolAddLabTest_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsTypesPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int recordID = (int)dgvPatientRecords.CurrentRow.Cells[0].Value;

            frmAddUpdateLabTests frm = new frmAddUpdateLabTests(recordID);
            frm.ShowDialog();
        }

        private void toolIssuePrescription_Click(object sender, EventArgs e)
        {

            if (!PermissionManager.HasPermission(GeneralPermissions.PrescriptionsPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int recordID = (int)dgvPatientRecords.CurrentRow.Cells[0].Value;

            frmIssuePrescription frm = new frmIssuePrescription(recordID);
            frm.ShowDialog();

        }

        

        private void toolRecordDetail_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.ViewItem))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int recordID = Convert.ToInt32(dgvPatientRecords.CurrentRow.Cells[0].Value);

            frmShowRecordDetail frm = new frmShowRecordDetail(recordID);
            frm.ShowDialog();
        }



        private void dgvPatientRecords_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvPatientRecords.Rows[e.RowIndex];

                bool isDeleted = Convert.ToBoolean(clickedRow.Cells["IsDeleted"].Value);

                if (isDeleted)
                {
                    dgvPatientRecords.ContextMenuStrip = null;
                }
                else
                {
                    dgvPatientRecords.ContextMenuStrip = RecordsMenu;
                    dgvPatientRecords.ClearSelection();
                    clickedRow.Selected = true;
                }
            }
        }


        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int testID = Convert.ToInt32(dgvPatientTests.CurrentRow.Cells[0].Value);
            int recordID = Convert.ToInt32(dgvPatientTests.CurrentRow.Cells[5].Value);

            frmAddUpdateLabTests frm = new frmAddUpdateLabTests(recordID, testID);
            frm.ShowDialog();
        }

        private void submitResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int testID = Convert.ToInt32(dgvPatientTests.CurrentRow.Cells[0].Value);

            frmSubmitLabTestResult frm = new frmSubmitLabTestResult(testID);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsPermissions, SubPermission.Delete))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int testID = Convert.ToInt32(dgvPatientTests.CurrentRow.Cells[0].Value);

            if (MessageBox.Show($"Are you sure to delete this Test with ID = {testID}?",
                 "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (labTestService.Delete(testID, Global.CurrentUser.UsertId))
                {
                    _LoadLabTestsDetail();

                    MessageBox.Show($"Lab Test with ID = {testID} Successfully Delete.",
                        "Success Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                else
                {
                    MessageBox.Show($"Lab Test Delete Failed.",
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.PrescriptionsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int prescriptionID = Convert.ToInt32(dgvPatientPrescriptions.CurrentRow.Cells[0].Value);
            int recordID = Convert.ToInt32(dgvPatientPrescriptions.CurrentRow.Cells[1].Value);

            frmIssuePrescription frm = new frmIssuePrescription(recordID, prescriptionID);
            frm.ShowDialog();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.Delete))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int prescriptionID = Convert.ToInt32(dgvPatientPrescriptions.CurrentRow.Cells[0].Value);
           
            if (MessageBox.Show($"Are you sure to delete this prescription with ID = {prescriptionID}?",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (prescriptionService.Delete(prescriptionID, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show($"Prescription with ID = {prescriptionID} Successfully Delete.",
                        "Success Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadPrescriptionsDetail();
                }
                else
                {
                    MessageBox.Show($"Prescription Delete Failed.",
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

  

        private void viewDetailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.MedicalRecordsPermissions, SubPermission.ViewItem))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int prescriptionID = Convert.ToInt32(dgvPatientPrescriptions.CurrentRow.Cells[0].Value);
            
            frmViewPrescriptionDetail frm = new frmViewPrescriptionDetail(prescriptionID);
            frm.ShowDialog();
        }

       
    }
}
