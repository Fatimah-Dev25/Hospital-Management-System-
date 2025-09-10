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

namespace HospitalManagementSystem.Forms.Invoices
{
    public partial class frmUpdateInvoiceItem : Form
    {
        private int _InvoiceItemID;
        InvoiceService _InvoiceService;
        InvoiceItem invoiceItem;
        public frmUpdateInvoiceItem(int invoiceItemID)
        {
            _InvoiceItemID = invoiceItemID;
            _InvoiceService = new InvoiceService();
            InitializeComponent();
        }

        private void frmUpdateInvoiceItem_Load(object sender, EventArgs e)
        {
            invoiceItem = _InvoiceService.GetInvoiceItemDetailByID(_InvoiceItemID);

            if (invoiceItem == null) {

                MessageBox.Show("There is no Invoice Item with ID: " + _InvoiceItemID + ".",
                    "Not Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }

            lblInvoiceItemID.Text = invoiceItem.InvoiceID.ToString();
            lblInvoiceID.Text = invoiceItem.InvoiceID.ToString();
            lblItemID.Text = invoiceItem.ItemID.ToString();
            txtItemType.Text = invoiceItem.ItemType;
            txtDescription.Text = invoiceItem.Description;
            txtPrice.Text = invoiceItem.Price.ToString();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = (txtPrice.Text.Contains("."));
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text) ||
                string.IsNullOrEmpty(txtItemType.Text)) {

                MessageBox.Show("Check Form, Some Fields required..",
                    "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                return;
            }

            invoiceItem.ItemType = txtItemType.Text;
            invoiceItem.Description = txtDescription.Text;
            invoiceItem.Price = Convert.ToDouble(txtPrice.Text);

            if (_InvoiceService.UpdateInvoiceItemByID(invoiceItem, 1))
            {
                MessageBox.Show("Invoice Item has updated successfully",
                    "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Invoice Item has updated Failed.",
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
