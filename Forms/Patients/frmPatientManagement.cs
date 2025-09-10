using ClosedXML.Excel;
using HospitalManagementSystem.Forms.People;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Properties;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmPatientManagement : Form
    {
        PatientService _PatientService = new PatientService();
        DataTable _PatientsList = new DataTable();
        public frmPatientManagement()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            _PatientsList = _PatientService.GetAll();

            dgvPatientsList.DataSource = null;
            dgvPatientsList.Columns.Clear();

            dgvPatientsList.DataSource = _PatientsList;
            dgvPatientsList.RowTemplate.Height = 30;

            if (dgvPatientsList.Rows.Count > 0)
            {

                dgvPatientsList.Columns[0].Width = 60;
                dgvPatientsList.Columns[0].HeaderText = "ID";

                dgvPatientsList.Columns[1].Width = 120;
                dgvPatientsList.Columns[1].HeaderText = "#File Number";

                dgvPatientsList.Columns[2].Width = 260;
                dgvPatientsList.Columns[2].HeaderText = "Patient Name";

                dgvPatientsList.Columns[3].Width = 150;
                dgvPatientsList.Columns[3].HeaderText = "Birth Date";

                dgvPatientsList.Columns[4].Width = 180;
                dgvPatientsList.Columns[4].HeaderText = "Phone";

                dgvPatientsList.Columns[5].Width = 140;
                dgvPatientsList.Columns[5].HeaderText = "Blood Type";

                dgvPatientsList.Columns[6].Width = 110;
                dgvPatientsList.Columns[6].HeaderText = "Gender";
            }


            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Image = Image.FromFile("Resources\\pen.png");
            editColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            editColumn.HeaderText = "Edit";
            editColumn.Name = "btnEdit";
            editColumn.Width = 90;
            dgvPatientsList.Columns.Add(editColumn);

            DataGridViewImageColumn viewInfoColumn = new DataGridViewImageColumn();
            viewInfoColumn.HeaderText = "Show Info";
            viewInfoColumn.Image = Image.FromFile("Resources\\file.png");
            viewInfoColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            viewInfoColumn.Name = "btnViewInfo";
            viewInfoColumn.Width = 90;
            dgvPatientsList.Columns.Add(viewInfoColumn);


            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Image = Image.FromFile("Resources\\delete.png");
            deleteColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
            deleteColumn.Name = "btnDelete";
            deleteColumn.Width = 90;
            dgvPatientsList.Columns.Add(deleteColumn);


        }


        private void frmPatientManagement_Load_1(object sender, EventArgs e)
        {
            _LoadData();
            cbFilterBy.SelectedIndex = 0;

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterby.Visible = cbFilterBy.Text != "None";

            if (txtFilterby.Visible)
            {

                txtFilterby.Text = "";
                txtFilterby.Focus();
            }

            if (cbFilterBy.Text == "None")
                _PatientsList.DefaultView.RowFilter = "";

        }

        private void txtFilterby_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {

                case "None":
                    FilterColumn = "None";
                    break;

                case "File Number":
                    FilterColumn = "FileNumber";
                    break;

                case "Patient Name":
                    FilterColumn = "Fullname";
                    break;
            }

            if (FilterColumn == "None")
                _PatientsList.DefaultView.RowFilter = "";
            else
                _PatientsList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn,
                    txtFilterby.Text.Trim());
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.PatientsPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            Form frm = new frmAddEditPatient();
            frm.ShowDialog();

            frmPatientManagement_Load_1(null, null);
        }

        private void dgvPatientsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvPatientsList.Columns[e.ColumnIndex].Name;
                int patientId = Convert.ToInt32(dgvPatientsList.Rows[e.RowIndex].Cells["PatientID"].Value);

                if (columnName == "btnEdit")
                {
                    if (!PermissionManager.HasPermission(GeneralPermissions.PatientsPermissions, SubPermission.Edit))
                    {
                        MessageBox.Show(
                        "You don’t have permission to perform this action.",
                        "Permission Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                        return;
                    }

                    frmAddEditPatient frm = new frmAddEditPatient(patientId);
                    frm.ShowDialog();

                    frmPatientManagement_Load_1(null, null);


                }
                else if (columnName == "btnDelete")
                {
                    if (!PermissionManager.HasPermission(GeneralPermissions.PatientsPermissions, SubPermission.Delete))
                    {
                        MessageBox.Show(
                        "You don’t have permission to perform this action.",
                        "Permission Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                        return;
                    }

                    if (MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Deletion",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (_PatientService.Delete(patientId, Global.CurrentUser.UsertId))
                        {
                            MessageBox.Show("Patient Deleted Successfully", "Delete"
                                , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Patient Deleted Faild", "Delete"
                                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    frmPatientManagement_Load_1(null, null);

                }
                else if (columnName == "btnViewInfo")
                {
                    if (!PermissionManager.HasPermission(GeneralPermissions.PatientsPermissions, SubPermission.ViewItem))
                    {
                        MessageBox.Show(
                        "You don’t have permission to perform this action.",
                        "Permission Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                        return;
                    }

                    frmPatientDetail frm = new frmPatientDetail(patientId);
                    frm.ShowDialog();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmEdit = new frmAddEditPerson(7);
            frmEdit.ShowDialog();
        }

        private void ExportData(string FilePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(_PatientsList, "Sheet1");
                workbook.SaveAs(FilePath);
            }


        }
        private void btnExportData_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\AdminFiles\ProjectsFiles\Hospital_System\PatientsData.xlsx";


            try
            {
                ExportData(filePath);
                MessageBox.Show("Data has been successfully exported!", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void dgvPatientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
