using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.StaffForms
{
    public partial class frmShowEmployeeDetail : Form
    {
        StaffService _Service;
        private int _EmpID;
        private StaffEntity _CurrentEmployee;
        public frmShowEmployeeDetail(int empID)
        {
            _EmpID = empID;
            _Service = new StaffService();
            InitializeComponent();
        }

        private void frmShowEmployeeDetail_Load(object sender, EventArgs e)
        {
            _CurrentEmployee = _Service.GetById(_EmpID);

            if (_CurrentEmployee == null) {
            
                MessageBox.Show("This employee isn't exists in system..", "Not Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _FillDataInControls();
        }

        private void _FillDataInControls()
        {
            lblEmpID.Text = _CurrentEmployee.StaffId.ToString();
            ucPersonView1.LoadPersonInControl(_CurrentEmployee.PersonID);
            lblPosition.Text = _CurrentEmployee.JobTitle;
            lblHireDate.Text = _CurrentEmployee.DateHired.ToString("MMM, dd/yyyy");
            lblShiftType.Text = _CurrentEmployee.ShiftType.ToString();
            lblDepartment.Text = _CurrentEmployee.DeptText;
            rbActive.Checked = _CurrentEmployee.isActive;
        }
    }
}
