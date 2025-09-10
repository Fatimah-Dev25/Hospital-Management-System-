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

namespace HospitalManagementSystem.Forms.LabTests
{
    public partial class frmTestTypeManagement : Form
    {
        TestTypeService _testTypeService;
        List<TestType> _TestTypesList;
        public frmTestTypeManagement()
        {
            _testTypeService = new TestTypeService();
            InitializeComponent();
        }

        private void _RefreshTestTypesGrid()
        {
            _TestTypesList = _testTypeService.GetTypesList();

            dgvTestTypeSettings.DataSource = _TestTypesList;
            dgvTestTypeSettings.Columns["Description"].Visible = false;
            dgvTestTypeSettings.Columns["Price"].Visible = false;

            dgvTestTypeSettings.Columns["TestTypeID"].Width = 90;
            dgvTestTypeSettings.Columns["TestTypeName"].Width = 140;
        }
        private void frmTestTypeManagement_Load(object sender, EventArgs e)
        {
           
            _RefreshTestTypesGrid();
        }

        private void llAddNewTestType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
            frmAddUpdateNewTestType frm = new frmAddUpdateNewTestType();
            frm.ShowDialog();
            _RefreshTestTypesGrid();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsTypesPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            int typeID = Convert.ToInt32(dgvTestTypeSettings.CurrentRow.Cells[0].Value);

            frmAddUpdateNewTestType frm = new frmAddUpdateNewTestType(typeID);
            frm.ShowDialog();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsTypesPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;

            }

            int typeID = Convert.ToInt32(dgvTestTypeSettings.CurrentRow.Cells[0].Value);

            if(_testTypeService.ChangeTestTypeActivation(typeID, true,1))
            {
                MessageBox.Show("Test Type has been activated successfully.",
                    "Test Type Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Test Type has been activated Failed.",
                    "Test Type Activation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deactiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.LabTestsTypesPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;
            }

            int typeID = Convert.ToInt32(dgvTestTypeSettings.CurrentRow.Cells[0].Value);

            if (_testTypeService.ChangeTestTypeActivation(typeID, false, 1))
            {
                MessageBox.Show("Test Type has been deactivated successfully.",
                    "Test Type Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Test Type has been deactivated Failed.",
                    "Test Type Activation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
