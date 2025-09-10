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
    public partial class frmPaymentsHistory : Form
    {
        private int _InvoiceID;
        InvoiceService invoiceService;
        DataTable _PaymentsList;
        public frmPaymentsHistory(int invoiceID)
        {
            _InvoiceID = invoiceID;
            invoiceService = new InvoiceService();
            InitializeComponent();
        }

        private void frmPaymentsHistory_Load(object sender, EventArgs e)
        {
            lblInvoiceID.Text = _InvoiceID.ToString();
            _PaymentsList = invoiceService.GetInvoicePayments(_InvoiceID);

            dgvPaymentsList.DataSource = _PaymentsList;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
