using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using Microsoft.VisualBasic;
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
    public partial class frmAddUpdateLabTests : Form
    {
        enum enMode { AddNew, Update}

        private int _labTestID;
        private LabTest _CurrentTest;
        private LabTestService _Service;
        private enMode _CurrentMode;
        List<(int ID, string Type)> _TestTypes;
        public frmAddUpdateLabTests(int recordID, int labTestID = 0)
        {
            _Service = new LabTestService();
            InitializeComponent();
  
            if(labTestID == 0)
            {
                _CurrentMode = enMode.AddNew;
                _CurrentTest = new LabTest();
                _CurrentTest.MedicalRecordID = recordID;
            }
            else
            {
                _CurrentMode = enMode.Update;
                _labTestID = labTestID;
            }
            
            
        }

        private void frmAddUpdateLabTests_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_CurrentMode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _CurrentTest = _Service.GetById(_labTestID);

            if(_CurrentTest == null)
            {
                MessageBox.Show($"There is no Test with ID: {_labTestID}", "Not Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtpLabTestDate.MinDate = _CurrentTest.TestDate;

            cbTestTypes.SelectedValue = _CurrentTest.TestTypeID;
            lblLabTestID.Text = _CurrentTest.LabTestID.ToString();
            txtResult.Text = _CurrentTest.Result;
            txtNotes.Text = _CurrentTest.Notes;
            dtpLabTestDate.Value = _CurrentTest.TestDate;


        }

        private void _ResetDefaultValues()
        {
            lblLabTestID.Text = "???";
            txtResult.Text = "";
            txtNotes.Text = "";
            dtpLabTestDate.Value = DateTime.Now;

            _FillTypesInComboBox();
        }

        private void _FillTypesInComboBox()
        {
            _TestTypes = _Service.GetActiveTests();

            cbTestTypes.DataSource = _TestTypes.Select(item => new { item.ID, item.Type }).ToList();

            cbTestTypes.DisplayMember = "Type";
            cbTestTypes.ValueMember = "ID";
            
        }

        private bool _ValidateForm() => !string.IsNullOrEmpty(cbTestTypes.Text) &&
            dtpLabTestDate.Value != null;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm()) {

                MessageBox.Show("Please check the form. Some fields contain invalid or missing information.",
                         "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _MapFormToLabTest();

            if(_CurrentMode == enMode.AddNew)
            {
                _CurrentTest.LabTestID = _Service.Add(_CurrentTest);

                if(_CurrentTest.LabTestID > 0)
                {
                    lblLabTestID.Text = _CurrentTest.LabTestID.ToString();
                    _CurrentMode = enMode.Update;

                    MessageBox.Show("Lab test added successfully.", "Lab Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Lab test added Failed.", "Lab Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_Service.Update(_CurrentTest, Global.CurrentUser.UsertId))
                {

                    MessageBox.Show("Lab test updated successfully.", "Lab Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Lab test updated failed.", "Lab Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void _MapFormToLabTest()
        {
            _CurrentTest.TestTypeID = Convert.ToInt32(cbTestTypes.SelectedValue);

            _CurrentTest.TestDate = dtpLabTestDate.Value;

            _CurrentTest.CreatedByUserID = Global.CurrentUser.UsertId;

            if(!string.IsNullOrEmpty(txtResult.Text))
                _CurrentTest.Result = txtResult.Text;
            
            if(!string.IsNullOrEmpty(txtNotes.Text))
                _CurrentTest.Notes = txtNotes.Text;


        }
    }
}
