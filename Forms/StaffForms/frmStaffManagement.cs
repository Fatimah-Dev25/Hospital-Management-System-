using HospitalManagementSystem.Forms.Staff;
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

namespace HospitalManagementSystem.Forms.StaffForms
{
    public partial class frmStaffManagement : Form
    {
        DataTable _StaffData;
        StaffService _Service;

        public frmStaffManagement()
        {
            InitializeComponent();
            _Service = new StaffService();
        }

        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
            
        }

        private void _LoadData()
        {
            _StaffData = _Service.GetAll();
            if (_StaffData.Rows.Count > 0)
            {
                lblStaffCount.Text = _StaffData.Rows.Count.ToString() + " Employees.";
                dgvAllStaff.DataSource = _StaffData;

                dgvAllStaff.Columns[1].Width = 240;
                dgvAllStaff.Columns[2].Width = 210;
                dgvAllStaff.Columns[3].Width = 220;
                dgvAllStaff.Columns[7].Width = 140;
            }
            else
            {
                lblStaffCount.Text = "0 Employees.";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.StaffPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            frmAddUpdateEmployee frmAdd = new frmAddUpdateEmployee();
            frmAdd.ShowDialog();

            frmStaffManagement_Load(null, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.StaffPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );

                return;
            }
            if (dgvAllStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select an employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int empID = (int)dgvAllStaff.CurrentRow.Cells[0].Value;

            frmAddUpdateEmployee frmAdd = new frmAddUpdateEmployee(empID);
            frmAdd.ShowDialog();

            _LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.StaffPermissions, SubPermission.Delete))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            if (dgvAllStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select an employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int empID = (int)dgvAllStaff.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure to delete this employee? ", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){

                if (_Service.Delete(empID, Global.CurrentUser.UsertId)) {

                    MessageBox.Show($"Employee has ID : {empID} Deleted Successfully", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _LoadData();

                }
                else
                {

                    MessageBox.Show($"Employee has ID : {empID} Deleted Failed", "Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.StaffPermissions, SubPermission.ViewItem))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            if (dgvAllStaff.CurrentRow == null)
            {
                MessageBox.Show("Please select an employee.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int empID = (int)dgvAllStaff.CurrentRow.Cells[0].Value;

            frmShowEmployeeDetail frm = new frmShowEmployeeDetail(empID);
            frm.ShowDialog();
        }

        private void lblStaffCount_Click(object sender, EventArgs e)
        {

        }
    }
}
