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

namespace HospitalManagementSystem.Forms.LabTests
{
    public partial class frmSubmitLabTestResult : Form
    {
        private int _testID;
        private LabTestService _testService;
        private LabTest _CurrentLabTest;
        public frmSubmitLabTestResult(int testID)
        {
            _testID = testID;
            _testService = new LabTestService();
            InitializeComponent();
        }

        private void frmSubmitLabTestResult_Load(object sender, EventArgs e)
        {
            _CurrentLabTest = _testService.GetById( _testID );

            if (_CurrentLabTest == null) {

                MessageBox.Show("There is no Test with ID = " + _testID,
                    "Test Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblTestID.Text = _CurrentLabTest.LabTestID.ToString();
            lblTestDate.Text = _CurrentLabTest.TestDate.ToString("dddd, dd/MM/yyyy");
            lblTestName.Text = _CurrentLabTest.TestName;

            txtTestResult.Text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestResult.Text))
            {
                MessageBox.Show("Please enter the test result.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(_testService.UpdateLabTestResult(_CurrentLabTest.LabTestID, txtTestResult.Text, Global.CurrentUser.UsertId))
                MessageBox.Show("Test result has been submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Test result has been submitted Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
