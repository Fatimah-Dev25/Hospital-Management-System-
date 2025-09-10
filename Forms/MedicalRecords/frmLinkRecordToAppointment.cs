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

namespace HospitalManagementSystem.Forms.MedicalRecords
{
    public partial class frmLinkRecordToAppointment : Form
    {
        AppointmentService appointmentService;

        public delegate void OnRecordLinked(object sender, int recordId);
        public event OnRecordLinked RecordLinked;
        private int _AppointmentID;
        public frmLinkRecordToAppointment(int appointmentID)
        {            
            InitializeComponent();
            appointmentService = new AppointmentService();
            _AppointmentID = appointmentID;
        }

        private void txtRecordID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsNotEmpty(txtRecordID, errorProvider1, "Please enter Record Number.."))
                return;
            int recordID = Convert.ToInt32(txtRecordID.Text);

            if (appointmentService.IsRecordExits(recordID))
            {
                if(appointmentService.AssignAppointmentToRecord(_AppointmentID, recordID, Global.CurrentUser.UsertId))
                {
                    RecordLinked?.Invoke(this, recordID);
                    MessageBox.Show("Appointment assignment to record Successful..", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was a problem linking the appointment to the record.", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show($"There is no Record with ID {recordID} exits..", "Not Exits",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmLinkRecordToAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
