using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
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

namespace HospitalManagementSystem.Forms.Invoices
{
    public partial class frmPayInvoice : Form
    {
        InvoiceService invoiceService;
        private int _InvoiceID;
        private InvoiceStatus _InvoiceStatus;
        private double _TotalAmount;
        Payment _CurrentPayment;
        
        public frmPayInvoice(int invoiceID, InvoiceStatus status, double totalAmount)
        {
            _InvoiceID = invoiceID;
            _InvoiceStatus = status;
            _TotalAmount = totalAmount;
            invoiceService = new InvoiceService();
            InitializeComponent();
        }

        private void frmPayInvoice_Load(object sender, EventArgs e)
        {
            lblInvoiceID.Text = _InvoiceID.ToString();
            lblInvoiceAmount.Text = _TotalAmount.ToString() + " aed.";
            cbPayMethod.SelectedIndex = 0;
            if (_InvoiceStatus == InvoiceStatus.FullyPaid) {

                lblInvoiceStatus.Text = "Full Paid";
                txtAmountToPay.Text = _TotalAmount.ToString();
                txtAmountToPay.Enabled = false;

            }
            else
            {
                lblInvoiceStatus.Text = "Partially Paid";
                txtAmountToPay.Enabled = true;
                txtAmountToPay.Focus();

            }
        }

        private void txtAmountToPay_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = (txtAmountToPay.Text.Contains("."));
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool _ValidateAmount()
        {
            if(_InvoiceStatus == InvoiceStatus.FullyPaid) { return true; }
            else
            {
                if (Convert.ToDouble(txtAmountToPay.Text) >= _TotalAmount)
                    return false;
                else
                    return true;
            }

        }

        private void btnPayInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmountToPay.Text))
            {
                MessageBox.Show("There is feild required, please cheack Form", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_ValidateAmount()) {
                MessageBox.Show("You have selected partial payment.\r\nYou must enter an amount less than the invoice Amount.", "Validation",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _MapDataToModel();

            _CurrentPayment.PaymentID = invoiceService.PerformInvoice(_CurrentPayment, _InvoiceStatus);

            if (_CurrentPayment.PaymentID > 0)
            {
                MessageBox.Show("Your payment has been completed successfully.","Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Your payment failed.", "Payment",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _MapDataToModel()
        {
            _CurrentPayment = new Payment();
            _CurrentPayment.InvoiceID = _InvoiceID;
            
            if (_InvoiceStatus == InvoiceStatus.FullyPaid)
                _CurrentPayment.AmountPaid = _TotalAmount;
            else
                _CurrentPayment.AmountPaid = Convert.ToDouble(txtAmountToPay.Text);
            
            _CurrentPayment.PaymentMethod = (PaymentMethod)cbPayMethod.SelectedIndex;
            _CurrentPayment.EnteredByID = 1;

        }
    }
}
