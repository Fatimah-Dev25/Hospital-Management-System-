using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Properties;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using HospitalManagementSystem.Utilities.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Doctors
{
    public partial class DoctorCard : UserControl
    {
        private int _DoctorID;
        private Doctor _CurrentDoctor;
        private DoctorService _Service;

        public event Action<DoctorCard> DoctorDeleted;
        public DoctorCard()
        {
            InitializeComponent();
            _Service =  new DoctorService();
        }

        public void FillDoctorInfoInCard(int doctorID)
        {
            _DoctorID = doctorID;
            _CurrentDoctor = _Service.GetById(_DoctorID);

            if (_CurrentDoctor != null) {

                lblDoctorName.Text = "Dr. " + _CurrentDoctor.RelatedPerson.Fullname;
                lblSPECIALITY.Text = _CurrentDoctor.Specialization;
                lblExperienceYears.Text = _CurrentDoctor.ExperienceYears + " years.";
                lblBirthDate.Text = _CurrentDoctor.RelatedPerson.BirthDate.ToString("MMM, dd/ yyyy");
                lblHiredDate.Text = _CurrentDoctor.DateHired.ToString("MMM, dd/yyyy");
                btnCall.Text = _CurrentDoctor.RelatedPerson.Phone;

                string imagePath = _CurrentDoctor.RelatedPerson.ImagePath;
                if (!string.IsNullOrEmpty(imagePath))
                {
                    pbDoctorImage.Image = new Bitmap(imagePath);

                }
            }
            else
            {
                MessageBox.Show($"There is no Doctor with id {doctorID}", "Faild",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.DoctorPermissions, SubPermission.Delete))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            if (MessageBox.Show($"Are you sure to delete Doctor with ID : [{_DoctorID}]", "Delete",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (_Service.Delete(_DoctorID, Global.CurrentUser.UsertId))
                {
                    DoctorDeleted?.Invoke(this);
                    MessageBox.Show("Doctor Deleted Successfully..", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Doctor Deleted Faild..", "Faild",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.DoctorPermissions, SubPermission.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            frmAddEditDoctor frm = new frmAddEditDoctor(_DoctorID);
            frm.ShowDialog();

        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.DoctorPermissions, SubPermission.ViewItem))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }
            frmShowDoctorDetail frm = new frmShowDoctorDetail(_DoctorID);
            frm.ShowDialog();
        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implement yet...", "Not Implement",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
