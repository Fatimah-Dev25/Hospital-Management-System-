using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Utilities;
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
    public partial class frmDoctorsManagement : Form
    {
        private List<int> _DoctorsListID;
        private DoctorService _DoctorService;
        private DoctorCard _DoctorCard;
        public frmDoctorsManagement()
        {
            InitializeComponent();
           
            _DoctorService = new DoctorService();
        }

     
        private void frmDoctorsManagement_Load(object sender, EventArgs e)
        {
            panelDoctrosView.Controls.Clear();

            _DoctorsListID = _DoctorService.GetDoctorsID();

            foreach (int id in _DoctorsListID)
            {
                DoctorCard doctorCard = new DoctorCard();
                doctorCard.DoctorDeleted += _DoctorCard_Delete;
                
                doctorCard.Margin = new Padding(0, 20, 80, 0);
             
                doctorCard.FillDoctorInfoInCard(id);
             

                panelDoctrosView.Controls.Add(doctorCard);
            }

        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasPermission(GeneralPermissions.DoctorPermissions, SubPermission.Add))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;
            }

            frmAddEditDoctor frm = new frmAddEditDoctor();
            frm.DataBack += _AddDoctorIntoPanel;
            frm.ShowDialog();
        }

        private void _AddDoctorIntoPanel(object sender, int doctorID)
        {
            DoctorCard doctorCard = new DoctorCard();
            doctorCard.FillDoctorInfoInCard(doctorID);
            doctorCard.DoctorDeleted += _DoctorCard_Delete;
          
            doctorCard.Margin = new Padding(0, 0, 80, 0);
            panelDoctrosView.Controls.Add(doctorCard);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _DoctorCard_Delete(DoctorCard card) {

            card.DoctorDeleted -= _DoctorCard_Delete; 
            panelDoctrosView.Controls.Remove(card);
            card.Dispose();
        }
    }
}
