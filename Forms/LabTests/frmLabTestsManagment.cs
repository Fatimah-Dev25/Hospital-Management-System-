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

namespace HospitalManagementSystem.Forms.LabTests
{
    public partial class frmLabTestsManagment : Form
    {
        DataTable _TestsList;
        LabTestService _testService;
        public frmLabTestsManagment()
        {
            _testService = new LabTestService();
            InitializeComponent();
        }

        private void _RefreshTestsGrid()
        {
            _TestsList = _testService.GetAll();
            dgvAllLabTests.DataSource = _TestsList;

          //  dgvAllLabTests.Columns[3].Width = 140;
          //  dgvAllLabTests.Columns[4].Width = 140;
        }
        private void frmLabTestsManagment_Load(object sender, EventArgs e)
        {
            _RefreshTestsGrid();

            cbFilterTestsBy.SelectedIndex = 0;

        }

        private void cbFilterTestsBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterTests.Text = "";

            if (cbFilterTestsBy.Text == "None")
            {
                txtFilterTests.Visible = false;
                _RefreshTestsGrid();
            }

            if(cbFilterTestsBy.Text != "Test Date")
            {
                txtFilterTests.Visible = true;
                dtpFilterByDate.Visible = false;
            }
            else
            {
                txtFilterTests.Visible = false;
                dtpFilterByDate.Visible = true;
            }
        }

        private void txtFilterTests_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterTestsBy.Text == "Patient File")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void btnPerformFilter_Click(object sender, EventArgs e)
        {
            string columnFilter = "None";

            switch (cbFilterTestsBy.Text)
            {
                case "Patient File":
                    columnFilter = "FileNumber";
                    break;

                case "Patient Name":
                    columnFilter = "TestFor";
                    break;

                case "Doctor Name":
                    columnFilter = "OrderedByDoctor";
                    break;

                case "Test Date":
                    columnFilter = "TestDate";
                    break;

                default:
                    columnFilter = "None";
                    break;
            }

            if (columnFilter == "None")
                _TestsList.DefaultView.RowFilter = "";

             
            else if (columnFilter == "TestDate")
            {
                DateTime selectedDate = dtpFilterByDate.Value.Date;
                _TestsList.DefaultView.RowFilter = $"[TestDate] = #{selectedDate:MM/dd/yyyy}#";

            }else
               _TestsList.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", columnFilter,
                    txtFilterTests.Text.Trim());
        }

        private void btnAddLabTest_Click(object sender, EventArgs e)
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
            int recordID = Convert.ToInt32(dgvAllLabTests.CurrentRow.Cells[5].Value);

            frmAddUpdateLabTests frm = new frmAddUpdateLabTests(recordID);
            frm.ShowDialog();

            _RefreshTestsGrid();
        }

        private void btnUpdateTest_Click(object sender, EventArgs e)
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

            int recordID = Convert.ToInt32(dgvAllLabTests.CurrentRow.Cells[5].Value);
            int testID = Convert.ToInt32(dgvAllLabTests.CurrentRow.Cells[0].Value);

            frmAddUpdateLabTests frm = new frmAddUpdateLabTests(recordID, testID);
            frm.ShowDialog();

            _RefreshTestsGrid();
        }

        private void btnDeleteTest_Click(object sender, EventArgs e)
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
            int testID = Convert.ToInt32(dgvAllLabTests.CurrentRow.Cells[0].Value);

            if(MessageBox.Show($"Are you sure to delete this Test with ID = {testID}?",
                "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (_testService.Delete(testID, 1))
                {
                    MessageBox.Show($"Lab Test with ID = {testID} Successfully Delete.",
                        "Success Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshTestsGrid();
                }
                else
                {
                    MessageBox.Show($"Lab Test Delete Failed.",
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnAddResult_Click(object sender, EventArgs e)
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
            int testID = Convert.ToInt32(dgvAllLabTests.CurrentRow.Cells[0].Value);

            frmSubmitLabTestResult frm = new frmSubmitLabTestResult(testID);
            frm.ShowDialog();
        }

        private void llTestTypeManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsTypesPermissions, SubPermission.ViewList))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            frmTestTypeManagement frm = new frmTestTypeManagement();
            frm.ShowDialog();
        }

        private void dtpFilterByDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
