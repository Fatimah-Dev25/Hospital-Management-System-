using DocumentFormat.OpenXml.Spreadsheet;
using HospitalManagementSystem.Forms.MedicalRecords;
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

namespace HospitalManagementSystem.Forms.Appointments
{
    public partial class frmAppointmentsManagement : Form
    {
        AppointmentService appointmentService;
        DataTable _AllAppointments;
        List<(int ID, string Department)> _DepartmentsList;

        public frmAppointmentsManagement()
        {
            appointmentService = new AppointmentService();
            InitializeComponent();
        }

        private void frmAppointmentsManagement_Load(object sender, EventArgs e)
        {

            _LoadAppointmentsGrid();
            _ResetValues();
        }

        private void _ResetValues()
        {
            cbFilterBy.SelectedIndex = 0;

            txtFilterBy.Visible = false;
            cbDepartments.Visible = false;
            dtAppointmentDate.Visible = false;

            _DepartmentsList = appointmentService.GetDepartments();

            cbDepartments.DataSource = _DepartmentsList.Select(item => new { item.ID, item.Department }).ToList();

            cbDepartments.DisplayMember = "Department";
            cbDepartments.ValueMember = "ID";

        }

        private void _LoadAppointmentsGrid()
        {
            _AllAppointments = appointmentService.GetAll();
            dgvAllAppointments.DataSource = _AllAppointments;

            if (dgvAllAppointments.Rows.Count > 0)
            {

                dgvAllAppointments.Columns[0].HeaderText = "ID";

                dgvAllAppointments.Columns[1].Visible = false;
                dgvAllAppointments.Columns[2].Visible = false;
                dgvAllAppointments.Columns[5].Visible = false;

                dgvAllAppointments.Columns[3].HeaderText = "Patient";
                dgvAllAppointments.Columns[3].Width = 190;

                dgvAllAppointments.Columns[6].HeaderText = "Doctor";
                dgvAllAppointments.Columns[6].Width = 220;

                dgvAllAppointments.Columns[8].Width = 150;


                dgvAllAppointments.Columns[9].HeaderText = "Date";
                dgvAllAppointments.Columns[12].HeaderText = "Type";
                dgvAllAppointments.Columns[12].Width = 120;


                _AllAppointments.Columns["Status"].ReadOnly = false;
            }
        }




        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.SelectedIndex == 0)
                _AllAppointments.DefaultView.RowFilter = "";

            txtFilterBy.Visible = cbFilterBy.Text == "Patient Name" ||
                cbFilterBy.Text == "File Number" || cbFilterBy.Text == "Doctor";

            cbDepartments.Visible = cbFilterBy.Text == "Department";

            dtAppointmentDate.Visible = cbFilterBy.Text == "Date";

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {

                case "None":
                    FilterColumn = "None";
                    break;

                case "Patient Name":
                    FilterColumn = "PatientName";
                    break;

                case "File Number":
                    FilterColumn = "FileNumber";
                    break;

                case "Doctor":
                    FilterColumn = "DoctorName";
                    break;
            }

            if (FilterColumn == "None" || string.IsNullOrWhiteSpace(txtFilterBy.Text))
                _AllAppointments.DefaultView.RowFilter = "";
            
            else
                _AllAppointments.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn,
                    txtFilterBy.Text.Trim());
        }

        private void dtAppointmentDate_ValueChanged(object sender, EventArgs e)
        {

            DateTime selectedDate = dtAppointmentDate.Value.Date;

            _AllAppointments.DefaultView.RowFilter = $"[AppointmentDate] = #{selectedDate:MM/dd/yyyy}#";

        }

        private void cbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text != "Department")
                return;

            if (cbDepartments.SelectedIndex < 0)
            {
                _AllAppointments.DefaultView.RowFilter = "";
                return;
            }

            _AllAppointments.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "Department",
                    cbDepartments.Text);
        }

        private void addNewAppointment_Click(object sender, EventArgs e)
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

            int patientID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[2].Value);
            
            var frm = new frmAddEditAppointment(patientID);
            frm.ShowDialog();

            _LoadAppointmentsGrid();
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

            int appointmentID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[0].Value);
            int patientID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells["PatientID"].Value);
            int doctorID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells["DoctorID"].Value);
            string patient = dgvAllAppointments.CurrentRow.Cells["PatientName"].Value.ToString();
            
            var frm = new frmAddUpdateRecordInfo(appointmentID, patientID, doctorID, patient);
            frm.ShowDialog();


        }

        private void linkAppointmentToRecord_Click(object sender, EventArgs e)
        {
            int appointmentID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[0].Value);

            var frm = new frmLinkRecordToAppointment(appointmentID);
            frm.ShowDialog();
        }

        private void updateAppointment_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.AppointmentsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            int appointmentID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[0].Value);
            int patientID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells["PatientID"].Value);

            var frm = new frmAddEditAppointment(patientID, appointmentID);
            frm.ShowDialog();

            _LoadAppointmentsGrid();

        }

        private void AppointmentConfirm_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.AppointmentsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            int appointmentID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[0].Value);
            DataRowView drv = dgvAllAppointments.CurrentRow.DataBoundItem as DataRowView;
        
            if (appointmentService.UpdateAppointmentStatus(appointmentID, AppointmentStatus.Confirm, Global.CurrentUser.UsertId))
            {
                MessageBox.Show("Appointment has Confirmed Successfully.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                drv["Status"] = "Confirm";

            }
            else
            {

                MessageBox.Show("Appointment Confirmed Failed.",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentCancel_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.AppointmentsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            int appointmentID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[0].Value);
            DataRowView drv = dgvAllAppointments.CurrentRow.DataBoundItem as DataRowView;
            if (appointmentService.UpdateAppointmentStatus(appointmentID, AppointmentStatus.Cancel, Global.CurrentUser.UsertId))
            {
                MessageBox.Show("Appointment has Canceled Successfully.",
                    "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                drv["Status"] = "Cancel";

            }
            else
            {

                MessageBox.Show("Appointment Canceled Failed.",
                    "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteAppointment_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.AppointmentsPermissions, SubPermission.Delete))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            int appointmentID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[0].Value);
            DataGridViewRow selectedRow = dgvAllAppointments.CurrentRow;

            if (MessageBox.Show("Are you sure to delete this appointment?", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (appointmentService.Delete(appointmentID, Global.CurrentUser.UsertId))
                {
                    DataRowView drv = selectedRow.DataBoundItem as DataRowView;
                    MessageBox.Show("Appointment Deleted Successfully.",
                        "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (drv != null)
                        drv.Delete();
                }
                else
                {

                    MessageBox.Show("Appointment Deleted Failed.",
                        "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvAllAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAllAppointments.Rows)
            {
                if (row.IsNewRow) continue;

                var value = row.Cells["RecordID"].Value;

                if (value != DBNull.Value)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(216, 249, 153);
                    issueNewRecord.Enabled = false;
                    linkAppointmentToRecord.Enabled = false;
                    updateAppointment.Enabled = false;
                    AppointmentCancel.Enabled = false;
                    deleteAppointment.Enabled = false;
                }

            }
        }

        private void AppointmentComplete_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.AppointmentsPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            int appointmentID = Convert.ToInt32(dgvAllAppointments.CurrentRow.Cells[0].Value);
            DataRowView drv = dgvAllAppointments.CurrentRow.DataBoundItem as DataRowView;
          
            if (appointmentService.UpdateAppointmentStatus(appointmentID, AppointmentStatus.Complete, Global.CurrentUser.UsertId))
            {
                MessageBox.Show("Appointment has Completed Successfully.",
                    "Complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                drv["Status"] = "Complete";

            }
            else
            {

                MessageBox.Show("Appointment Completed Failed.",
                    "Complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
