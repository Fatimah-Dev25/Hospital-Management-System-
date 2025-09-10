using HospitalManagementSystem.Forms.Billings;
using HospitalManagementSystem.Forms.LabTests;
using HospitalManagementSystem.Forms.Prescriptions;
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

namespace HospitalManagementSystem.Forms.MedicalRecords
{
    public partial class frmMedicalRecordsManagement : Form
    {
        BindingSource bindingSource = new BindingSource();

        MedicalRecordService _RecordService;
        DataTable _RecordsList;
        public frmMedicalRecordsManagement()
        {
            _RecordService = new MedicalRecordService();
            InitializeComponent();
        }

        private void _LoadRecordsGrid()
        {
            _RecordsList = _RecordService.GetAll();
            bindingSource.DataSource = _RecordsList;

            dgvAllRecords.DataSource = bindingSource;

            if (dgvAllRecords.Rows.Count > 0) {

                dgvAllRecords.Columns[1].HeaderText = "Patient";
                dgvAllRecords.Columns[1].Width = 190;

                dgvAllRecords.Columns[2].HeaderText = "Doctor";
                dgvAllRecords.Columns[2].Width = 190;

                dgvAllRecords.Columns[3].Width = 130;
                dgvAllRecords.Columns[4].Width = 130;

                dgvAllRecords.Columns[5].Width = 140;
                
                dgvAllRecords.Columns[6].Visible = false;
                dgvAllRecords.Columns["HasRecordActiveAppointment"].Visible = false;

                dgvAllRecords.Columns[7].Width = 140;
                
                dgvAllRecords.Columns[8].HeaderText = "Created By";

                lblRecordsCount.Text = dgvAllRecords.Rows.Count.ToString();
            }


        }
        private void frmMedicalRecordsManagement_Load(object sender, EventArgs e)
        {
            _LoadRecordsGrid();            
            cbFilterBy.SelectedIndex = 0;

            lblRecordsCount.Text = dgvAllRecords.Rows.Count.ToString() + " Records.";
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "None":
                    FilterColumn = "None";
                    break;

                case "Record ID":
                    FilterColumn = "RecordID";
                    break;

                case "Patient Name":
                    FilterColumn = "PatientName";
                    break;

                case "Record Date":
                    FilterColumn = "RecordDate";
                    break;


            }


            if (FilterColumn == "None" || string.IsNullOrWhiteSpace(txtFilterBy.Text))
            {
                bindingSource.RemoveFilter();
                return;
            }

            else if (FilterColumn == "RecordID")
                bindingSource.Filter = string.Format("[{0}] = '{1}'", FilterColumn, Convert.ToInt32(txtFilterBy.Text.Trim()));

            else
                bindingSource.Filter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblRecordsCount.Text = dgvAllRecords.Rows.Count.ToString() + " Records.";



        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Record ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void dtpRecordDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpRecordDate.Value;
            DateTime startDate = selectedDate.Date;
            DateTime endDate = selectedDate.Date.AddDays(1);
            bindingSource.Filter = $"RecordDate >= #{startDate:MM/dd/yyyy}# AND RecordDate < #{endDate:MM/dd/yyyy}#";

            lblRecordsCount.Text = dgvAllRecords.Rows.Count.ToString() + " Records.";

        }

        private void addLabTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }
            int recordID = Convert.ToInt32(dgvAllRecords.CurrentRow.Cells[0].Value);

            var frm = new frmAddUpdateLabTests(recordID);
            frm.ShowDialog();
        }

        private void issuePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
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
            int recordID = Convert.ToInt32(dgvAllRecords.CurrentRow.Cells[0].Value);

            var frm = new frmIssuePrescription(recordID);
            frm.ShowDialog();
        }

        private void generateInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.IssueInvoice))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }
            int recordID = Convert.ToInt32(dgvAllRecords.CurrentRow.Cells[0].Value);

            int invoiceID = _RecordService.GenerateInvoice(recordID, 1);
            if (invoiceID > 0) {

                if(MessageBox.Show($"The invoice with ID: {invoiceID} has been issued successfully." +
                    $"Do you want to show Detail?", "Invoice Generate",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var frm = new frmViewUpdateInvoiceDetail(invoiceID, frmViewUpdateInvoiceDetail.Mode.ViewDetail);
                    frm.ShowDialog();
                }

            
            }
            else
            {
                MessageBox.Show("Invoice Generation Failed..", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewRecordDetailToolStripMenuItem_Click(object sender, EventArgs e)
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

            int recordID = Convert.ToInt32(dgvAllRecords.CurrentRow.Cells[0].Value);

            var frm = new frmShowRecordDetail(recordID);
            frm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
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

            int recordID = Convert.ToInt32(dgvAllRecords.CurrentRow.Cells[0].Value);
            string patientName = dgvAllRecords.CurrentRow.Cells[1].Value.ToString();
            
            var frm = new frmAddUpdateRecordInfo(recordID, patientName);
            frm.ShowDialog();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
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

            int recordID = Convert.ToInt32(dgvAllRecords.CurrentRow.Cells[0].Value);


            if (MessageBox.Show("Are you sure to delete this record?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (_RecordService.Delete(recordID, 1))
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

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterBy.Visible = cbFilterBy.Text != "None" && cbFilterBy.Text != "Record Date";

            dtpRecordDate.Visible = cbFilterBy.Text == "Record Date";

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }

            if(cbFilterBy.Text == "None")
            {
                bindingSource.RemoveFilter();
                lblRecordsCount.Text = dgvAllRecords.Rows.Count.ToString() + " Records.";

            }

        }

        private void dgvAllRecords_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvAllRecords.Rows[e.RowIndex];

                bool isDeleted = Convert.ToBoolean(clickedRow.Cells["IsDeleted"].Value);

                if (isDeleted)
                {
                    dgvAllRecords.ContextMenuStrip = null;
                }
                else
                {
                    dgvAllRecords.ContextMenuStrip = RecordsMenu;
                    dgvAllRecords.ClearSelection();
                    clickedRow.Selected = true;
                }
            }
        }

        private void dgvAllRecords_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAllRecords.Rows)
            {
                if (row.IsNewRow) continue;

                var value = row.Cells["IsDeleted"].Value;
                var checkActiveAppointment = Convert.ToInt32(row.Cells["HasRecordActiveAppointment"].Value);
                
                if (Convert.ToBoolean(value))
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(82, 82, 82);
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }

                if(checkActiveAppointment != 1)
                {
                    addLabTestToolStripMenuItem.Enabled = false;
                    issuePrescriptionToolStripMenuItem.Enabled = false;
                    generateInvoiceToolStripMenuItem.Enabled = false;
                }
                

            }
        }
    }
}
