using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Prescriptions
{
    public partial class frmViewPrescriptionDetail : Form
    {
        PrescriptionService _PrescriptionService;
        Prescription _PrescriptionEntity;
        List<MedicationItem> _DrugsList;
        private int _PrescriptionId;
        public frmViewPrescriptionDetail(int prescriptionID)
        {
            _DrugsList = new List<MedicationItem>();
            _PrescriptionId = prescriptionID;
            _PrescriptionService = new PrescriptionService();
            InitializeComponent();
        }

        private void frmViewPrescriptionDetail_Load(object sender, EventArgs e)
        {
            _FillDataInControls();
        }

        private void _FillDataInControls()
        {
            _PrescriptionEntity = _PrescriptionService.GetById(_PrescriptionId);

            if (_PrescriptionEntity == null)
            {

                MessageBox.Show($"There is no prescription with ID: {_PrescriptionId}..",
                    "Record Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
                return;

            }

            lblPrescriptionFor.Text = _PrescriptionEntity.PrescriptionFor;
            lblPrescriptionDoctor.Text = _PrescriptionEntity.PrescriptionOrderBy;
            lblPresID.Text = _PrescriptionEntity.PrescriptionId.ToString();
            lblPresDate.Text = _PrescriptionEntity.DateIssued.ToString("dddd,   MMM dd/yyyy");
            _DrugsList = JsonConvert.DeserializeObject<List<MedicationItem>>(_PrescriptionEntity.PrescriptionText);
            dgvPresDrugs.DataSource = _DrugsList;
        }

        private void llPrintPrescription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Not Implemented",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
