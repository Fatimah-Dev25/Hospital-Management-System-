using HospitalManagementSystem.Models;
using HospitalManagementSystem.Utilities.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Doctors
{
    public partial class frmShowDoctorDetail : Form
    {
        private int _DoctorID;
        private Doctor _CurrentDoctor;
        private DoctorService doctorService;
        public frmShowDoctorDetail(int doctorID)
        {
            InitializeComponent();
            _DoctorID = doctorID;
            doctorService = new DoctorService();
        }

        private void frmShowDoctorDetail_Load(object sender, EventArgs e)
        {
            _CurrentDoctor = doctorService.GetById(_DoctorID);

            if(_CurrentDoctor != null)
            {
                lblDoctorID.Text = _CurrentDoctor.DoctorID.ToString();
                lblSpecialization.Text = _CurrentDoctor.Specialization;
                lblDateHired.Text = _CurrentDoctor.DateHired.ToString("MMM, dd, yyyy");
                lblExpYears.Text = _CurrentDoctor.ExperienceYears + " years.";
                ucPersonView1.LoadPersonInControl(_CurrentDoctor.PersonID);
                lblDept.Text = _CurrentDoctor.DepartmentTilte;
            }
        }


    }
}
