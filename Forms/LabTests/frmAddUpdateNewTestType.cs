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
    public partial class frmAddUpdateNewTestType : Form
    {
        enum Mode { AddNew, Update}
        TestTypeService _testTypeService;
        private int _TestTypeID;
        TestType _CurrentTestType;
        Mode _CurrentMode;
        public frmAddUpdateNewTestType()
        {
            _CurrentMode = Mode.AddNew;
            _testTypeService = new TestTypeService();
            InitializeComponent();
        }
        public frmAddUpdateNewTestType(int typeID)
        {
            _TestTypeID = typeID;
            _CurrentMode = Mode.Update;
            _testTypeService = new TestTypeService();
            InitializeComponent();
        }

        private void frmAddUpdateNewTestType__Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_CurrentMode == Mode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _CurrentTestType = _testTypeService.GetById(_TestTypeID);

            if( _CurrentTestType == null)
            {
                MessageBox.Show($"There is no Test Type with ID = {_TestTypeID}.",
                    "Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Text = "Update Test Type Detail";
            lblTestTypeID.Text = _CurrentTestType.TestTypeID.ToString();
            txtTestName.Text = _CurrentTestType.TestTypeName;
            txtDescription.Text = _CurrentTestType.Description;
            txtPrice.Text = _CurrentTestType.Price.ToString();
            rbAcive.Checked = _CurrentTestType.isActive;
        }

        private void _ResetDefaultValues()
        {
            lblTestTypeID.Text = "[???]";
            txtTestName.Text = "";
            txtPrice.Text = "";
            txtDescription.Text = "";
            rbAcive.Checked = false;

            if (_CurrentMode == Mode.AddNew) {

                this.Text = "Add New Test Type";
                _CurrentTestType = new TestType();
            }
        }

        private bool _ValidateForm()
        {
            return ValidationHelper.IsNotEmpty(txtTestName, errorProvider1) &&
             ValidationHelper.IsNotEmpty(txtPrice, errorProvider1);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = (txtPrice.Text.Contains("."));
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm()) {

                MessageBox.Show("Please Check Form, some fields is required..", "Validation"
                    , MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            _CurrentTestType.TestTypeName = txtTestName.Text;
            _CurrentTestType.Description = txtDescription.Text;
            _CurrentTestType.Price = Convert.ToDouble(txtPrice.Text);
            _CurrentTestType.isActive = rbAcive.Checked;

            if(_CurrentMode == Mode.AddNew)
            {
               _CurrentTestType.TestTypeID = _testTypeService.Add(_CurrentTestType, Global.CurrentUser.UsertId);
                
                if (_CurrentTestType.TestTypeID > 0) {

                    _CurrentMode = Mode.Update;
                    lblTestTypeID.Text = _CurrentTestType.TestTypeID.ToString();
                    MessageBox.Show($"New Test Type added Successfuly with ID = {_CurrentTestType.TestTypeID}.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"New Test Type added Failed.",
                        "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (_testTypeService.Update(_CurrentTestType, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("Test Type updated Successfuly.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Test Type updated Falied.",
                         "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
