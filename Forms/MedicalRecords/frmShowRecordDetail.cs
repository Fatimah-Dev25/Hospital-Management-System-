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

namespace HospitalManagementSystem.Forms.MedicalRecords
{
    public partial class frmShowRecordDetail : Form
    {
        private int _RecordID;
        MedicalRecordService recordService;
        public frmShowRecordDetail(int recordID)
        {
            _RecordID = recordID;
            recordService = new MedicalRecordService();
            InitializeComponent();
        }

        private void frmShowRecordDetail_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            MedicalRecord record = recordService.GetById(_RecordID);

            if (record == null) {

                MessageBox.Show($"There is no medical record has ID {_RecordID}...",
                    "Record Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lblRecordID.Text = record.RecordID.ToString();
            lblRecordDate.Text = record.RecordDate.ToString("dddd, dd/MM/yyyy");
            lblPatientName.Text = record.PatientName;
            lblDoctorName.Text = record.DoctorName;
            lblDepartment.Text = record.Department;
            lblDiagnosis.Text = record.Diagnosis;
            lblTreatment.Text = record.Treatment;
            lblNotes.Text = record.Notes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
