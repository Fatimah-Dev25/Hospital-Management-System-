using HospitalManagementSystem.Forms.Invoices;
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

namespace HospitalManagementSystem.Forms.Billings
{
    public partial class frmViewUpdateInvoiceDetail : Form
    {
        public enum Mode { Update, ViewDetail};
        private Mode _CurrentMode;

        Invoice _CurrentInvoice;
        InvoiceService _invoiceService;
        int _InvoiceID;
        Patient _PatientInfo;
        List<int> _ItemsToDelete;
        public frmViewUpdateInvoiceDetail(int invoiceID, Mode mode)
        {
            InitializeComponent();
        
            _CurrentMode = mode;
            _InvoiceID = invoiceID;
            _invoiceService = new InvoiceService();

        }

        private void frmViewInvoiceDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = _invoiceService.GetInvoiceItems(_InvoiceID);

            if(dt != null ) 
                dgvInvoiceItems.DataSource = dt;

            
            _LoadData();
            _HandleMode();            
                
        }

        private void _HandleMode()
        {
            if( _CurrentMode == Mode.Update)
            {
                dgvInvoiceItems.ContextMenuStrip = invoiceItemMenu;
                txtInvoiceDescription.Enabled = true;
                btnUpdateInvoice.Visible = true;
                btnPrint.Visible = false;
                btnExportToPdf.Visible = false;

            }
            else
            {
                dgvInvoiceItems.ContextMenuStrip = null;
                txtInvoiceDescription.Enabled = false;
                btnUpdateInvoice.Visible = false;
                btnPrint.Visible = true;
                btnExportToPdf.Visible = true;
            }
        }

        private void _LoadData()
        {
            _CurrentInvoice = _invoiceService.GetInvoiceInfoById(_InvoiceID);
            _ItemsToDelete = new List<int>();

            if (_CurrentInvoice != null)
            {
                lblInvoiceID.Text = _CurrentInvoice.InvoiceID.ToString();
                lblInvoiceDate.Text = _CurrentInvoice.InvoiceIssuedDate.ToString("MMM, dd/ yyyy hh:mm:ss");
                lblStatus.Text = _CurrentInvoice.Status.ToString();
                lblInvoiceAmount.Text = _CurrentInvoice.TotalAmount.ToString();
                lblRecordID.Text = _CurrentInvoice.MedicalRecordID.ToString();
                txtInvoiceDescription.Text = _CurrentInvoice.ServiceDescription;
            }

            _PatientInfo = _invoiceService.GetPatientInfoByInvoiceID(_InvoiceID);

            if (_PatientInfo != null) {

                lblPatientName.Text = _PatientInfo.RelatedPerson.Fullname;
                lblFileNumber.Text = _PatientInfo.FileNumber;
                lblGender.Text = _PatientInfo.RelatedPerson.Gender.ToString();
                lblBirthDate.Text = _PatientInfo.RelatedPerson.BirthDate.ToString("dd, MMM/yyyy");
                lblPhone.Text = _PatientInfo.RelatedPerson.Phone;
                lblAdmissionStatus.Text = _PatientInfo.Status.ToString();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implement yet.",
                "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature not implement yet.",
               "Not Implemented", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int invoiceItem = Convert.ToInt32(dgvInvoiceItems.CurrentRow.Cells[0].Value);

            var frm =  new frmUpdateInvoiceItem(invoiceItem);
            frm.ShowDialog();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int invoiceItem = Convert.ToInt32(dgvInvoiceItems.CurrentRow.Cells[0].Value);
            double itemPrice = Convert.ToDouble(dgvInvoiceItems.CurrentRow.Cells[5].Value);


            if (MessageBox.Show("Are you sure to delete this Item?", "Delete Confirmation",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                _ItemsToDelete.Add(invoiceItem);
                lblInvoiceAmount.Text = (Convert.ToDouble(lblInvoiceAmount.Text) - itemPrice).ToString();
                dgvInvoiceItems.Rows.Remove(dgvInvoiceItems.CurrentRow);

                MessageBox.Show($"Item with ID : {invoiceItem} has deleted successfully.",
                    "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   
            
        }

        private void btnUpdateInvoice_Click(object sender, EventArgs e)
        {
            bool flag = true;
            
            if (_ItemsToDelete.Count > 0) {

                foreach (var item in _ItemsToDelete) {
                
                    if(!_invoiceService.DeleteInvoiceItem(item, 1)) flag = false;
                }
            }
            if(_invoiceService.UpdateInvoiceDescription(_InvoiceID, txtInvoiceDescription.Text, 1) && flag)
            {
                MessageBox.Show("Invoice Updated Successfully.", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Invoice Updated Failed.", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
