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

namespace HospitalManagementSystem.Forms.Staff
{
    public partial class frmAddUpdateEmployee : Form
    {
        enum Mode { AddNew, Update}
        Mode mode = Mode.AddNew;
        private int _EmpID;
        StaffEntity _Employee;
        StaffService _StaffService;
        List<(int ID, string Title)> _departmentsList;

        public frmAddUpdateEmployee()
        {
            mode = Mode.AddNew;
            _StaffService = new StaffService();
            InitializeComponent();
        }   
        
        public frmAddUpdateEmployee(int empID)
        {
            _EmpID = empID;
            mode = Mode.Update;
            _StaffService = new StaffService();
            InitializeComponent();
        }

        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            personCardWithFilter1.FilterFocus();
            _ResetDefaultValues();

            if (mode == Mode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _Employee = _StaffService.GetById(_EmpID);

            if (_Employee == null) { 
            
                MessageBox.Show($"There is no Employee with ID = {_EmpID}", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
   
            lblFormTitle.Text = "Update Employee Info";
            this.Text = lblFormTitle.Text;
            tpEmployeeDetail.Enabled = true;
            btnSave.Enabled = true;

            personCardWithFilter1.LoadPersonInfo(_Employee.PersonID);
            lblEmployeeID.Text = _Employee.StaffId.ToString();
            txtPosition.Text = _Employee.JobTitle;
            cbShifType.Text = _Employee.ShiftType.ToString();
            cbDepartments.Text = _departmentsList.FirstOrDefault(d => d.ID == _Employee.DepartmentID).Title;
            rbActive.Checked = (_Employee.isActive);
        }

        private void _ResetDefaultValues()
        {
            personCardWithFilter1.FilterFocus();

            tpEmployeeDetail.Enabled = false;
            btnSave.Enabled = false;
            
            if (mode == Mode.AddNew) {
            
                _Employee = new StaffEntity();
                lblFormTitle.Text = "Add New Employee";
                this.Text = lblFormTitle.Text;
            }
            lblEmployeeID.Text = "[###]";
            txtPosition.Text = "";
            cbDepartments.Text = "";
            cbShifType.SelectedIndex = 0;
            rbActive.Checked = false;

            _FillDepartmentsInComboBox();
        }

        private void _FillDepartmentsInComboBox()
        {
            _departmentsList = _StaffService.GetSupportDepartments();

            foreach (var item in _departmentsList) { 
            
                cbDepartments.Items.Add(item.Title);
            }
        }

        private void personCardWithFilter1_onPersonSelected(int obj)
        {
            if (mode == Mode.AddNew && _StaffService.IsEmployeeExistsForPerson(obj)) { 
            
                MessageBox.Show("This person already registed in system, choose another one.",
                    "Exists",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                personCardWithFilter1.FilterFocus();
                tpEmployeeDetail.Enabled = false;
                return;
            }

            tpEmployeeDetail.Enabled = true;
            tcEmployeeInfo.SelectedTab = tcEmployeeInfo.TabPages["tpEmployeeDetail"];
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateForm())
            {
                MessageBox.Show("Please check the form. Some fields contain invalid or missing information.",
              "Form Validation Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                return;

            }

            _Employee.PersonID = personCardWithFilter1.PersonID;
            _Employee.JobTitle = txtPosition.Text;
            _Employee.isActive = rbActive.Checked;
            _Employee.DateHired = dtpHireDate.Value;
            _Employee.DepartmentID = _departmentsList.FirstOrDefault(D => D.Title == cbDepartments.Text).ID;
            _Employee.ShiftType = (ShiftType)cbShifType.SelectedIndex;

            if (mode == Mode.AddNew)
            {

                _Employee.StaffId = _StaffService.Add(_Employee, Global.CurrentUser.UsertId);
                if (_Employee.StaffId > 0)
                {
                    MessageBox.Show("Employee Added Successfully", "Added",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblEmployeeID.Text = _Employee.StaffId.ToString();
                    mode = Mode.Update;
                    this.Text = "Update Employee Info";
                    lblFormTitle.Text = this.Text;

                }
                else
                {
                    MessageBox.Show("Employee Added Failed", "Failed",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_StaffService.Update(_Employee, Global.CurrentUser.UsertId))
                {
                    MessageBox.Show("Employee Updated Successfully", "Update",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee Updated Failed", "Failed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool _ValidateForm()
        {
            return ValidationHelper.IsNotEmpty(txtPosition, errorProvider1) &&
                !string.IsNullOrEmpty(cbDepartments.Text) &&
                !string.IsNullOrEmpty(cbShifType.Text);
                
        }

  
    }
}
