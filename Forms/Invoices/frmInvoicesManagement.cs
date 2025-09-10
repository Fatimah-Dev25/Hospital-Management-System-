using HospitalManagementSystem.Forms.Billings;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
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

namespace HospitalManagementSystem.Forms.Invoices
{
    public partial class frmInvoicesManagement : Form
    {
        BindingSource bindingSource = new BindingSource();

        InvoiceService _invoiceService;
        Invoice _invoiceEntity;
        DataTable _InvoicesList;
        public frmInvoicesManagement()
        {
            _invoiceService = new InvoiceService();
            InitializeComponent();
        }

        private void frmInvoicesManagement_Load(object sender, EventArgs e)
        {
            txtFilterInvoicesValue.Visible = false;
            dtpFilterInvoicesValue.Visible = false;
            cbFilterInvoicesBy.SelectedIndex = 0;
            _LoadInvoicesData();
        }
    
       private void _LoadInvoicesData()
        {
            _InvoicesList = _invoiceService.GetAllInvoices();

            bindingSource.DataSource = _InvoicesList.DefaultView;

            dgvAllInvoices.DataSource = bindingSource;
            lblInvoicesCount.Text = dgvAllInvoices.Rows.Count.ToString() + " Invoices.";

            dgvAllInvoices.Columns["PatientID"].Visible = false;
            dgvAllInvoices.Columns[3].Width = 200;
            dgvAllInvoices.Columns[4].Width = 140;
            dgvAllInvoices.Columns[5].Width = 120;
            dgvAllInvoices.Columns[6].Width = 140;
            dgvAllInvoices.Columns[7].Width = 220;
            dgvAllInvoices.Columns[8].Width = 140;
            dgvAllInvoices.Columns[9].Width = 150;

            
        }

        private void rbAllInvoices_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllInvoices.Checked)
            {
                (dgvAllInvoices.DataSource as BindingSource).RemoveFilter();
            }
            lblInvoicesCount.Text = dgvAllInvoices.Rows.Count.ToString() + " Invoices.";

        }

        private void rbViewPendingInvoices_CheckedChanged(object sender, EventArgs e)
        {
            if (rbViewPendingInvoices.Checked)
            {
                BindingSource bs = (BindingSource)dgvAllInvoices.DataSource;
                bs.Filter = "Status = 'Un paid'";
                lblInvoicesCount.Text = dgvAllInvoices.Rows.Count.ToString() + " Invoices.";

            }
        }

        private void cbFilterInvoicesBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterInvoicesValue.Visible = cbFilterInvoicesBy.Text != "None" && cbFilterInvoicesBy.Text != "Invoice Date";

            dtpFilterInvoicesValue.Visible = cbFilterInvoicesBy.Text == "Invoice Date";

            if(txtFilterInvoicesValue.Visible)
            {
                txtFilterInvoicesValue.Text = "";
                txtFilterInvoicesValue.Focus();
            }

            if (cbFilterInvoicesBy.Text == "None")
                bindingSource.RemoveFilter();

        }

        private void txtFilterInvoicesValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbFilterInvoicesBy.Text)
            {
                case "None":
                    FilterColumn = "None"; break;

                case "Record Number":
                    FilterColumn = "RecordID";
                    break;

                case "Patient File":
                    FilterColumn = "FileNumber";
                    break;
            
                case "Patient Name":
                    FilterColumn = "PatientName";
                    break;

                case "Invoice Date":
                    FilterColumn = "BillingDate";
                    break;
                   

            }

            if (FilterColumn == "None" || string.IsNullOrWhiteSpace(txtFilterInvoicesValue.Text))
            {
                bindingSource.RemoveFilter();
                return;
            }

            else if (FilterColumn == "RecordID")
                bindingSource.Filter = string.Format("[{0}] = '{1}'", FilterColumn, Convert.ToInt32(txtFilterInvoicesValue.Text.Trim()));

            else
                bindingSource.Filter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterInvoicesValue.Text.Trim());

            lblInvoicesCount.Text = dgvAllInvoices.Rows.Count.ToString() + " Invoices.";


        }

        private void checkItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtFilterInvoicesValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterInvoicesBy.Text == "Record Number")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void dtpFilterInvoicesValue_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpFilterInvoicesValue.Value;
            bindingSource.Filter = $"BillingDate = #{selectedDate:MM/dd/yyyy}#";

            lblInvoicesCount.Text = dgvAllInvoices.Rows.Count.ToString() + " Invoices.";

        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.ViewItem))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            int invoiceId = Convert.ToInt32(dgvAllInvoices.CurrentRow.Cells[0].Value);

            frmViewUpdateInvoiceDetail frm = new frmViewUpdateInvoiceDetail(invoiceId, frmViewUpdateInvoiceDetail.Mode.ViewDetail);
            frm.ShowDialog();
        }

        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.CancelInvoice))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            int invoiceId = Convert.ToInt32(dgvAllInvoices.CurrentRow.Cells[0].Value);

            if (_invoiceService.UpdateInvoiceStatus(invoiceId, (int)InvoiceStatus.Cancelled,1))
            {
                MessageBox.Show($"Invoice with ID: {invoiceId} has cancelled successfully.",
                    "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Invoice Cancel Failed.",
                    "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.ApplyDiscount))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }

            if (dgvAllInvoices.CurrentRow != null)
            {
                int invoiceId = Convert.ToInt32(dgvAllInvoices.CurrentRow.Cells["InvoiceID"].Value);

                double totalAmount = Convert.ToDouble(dgvAllInvoices.CurrentRow.Cells["TotalAmount"].Value);

                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter Discount Percentage:", "Apply Discount", "10");

                if (double.TryParse(input, out double discountPercent))
                {
                    double discountAmount = totalAmount * discountPercent / 100;
                    double newAmount = totalAmount - discountAmount;

                    dgvAllInvoices.CurrentRow.Cells["TotalAmount"].Value = newAmount;

                    Invoice invoice = _MapDataToModel(invoiceId, newAmount, discountPercent);
                    
                    if (_invoiceService.UpdateInvoiceInfo(invoice, 1))
                    {
                        MessageBox.Show($"Invoice has applied discount success with Value = {discountPercent}% , Total Amount became {newAmount} aed.",
                            "Apply Discount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed Apply discount of this invoice.",
                       "Apply Discount", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Invalid discount value.");
                }
            }
        }

        private Invoice _MapDataToModel(int invoiceId, double totalAmount, double discountPercent)
        {
            Invoice invoice = new Invoice();
            invoice.InvoiceID = invoiceId;
            invoice.TotalAmount = totalAmount;
            invoice.ServiceDescription = dgvAllInvoices.CurrentRow.Cells["ServiceDescription"].Value.ToString() + 
                $"| {discountPercent}% discount has been applied to this Invoice.";

            return invoice;
       
        }

        

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.Edit))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            int invoiceID = Convert.ToInt32(dgvAllInvoices.CurrentRow.Cells[0].Value);

            var frm = new frmViewUpdateInvoiceDetail(invoiceID, frmViewUpdateInvoiceDetail.Mode.Update);
            frm.ShowDialog();

            _LoadInvoicesData();
        }

        private void payFullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.PayInvoice))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            int invoiceId = Convert.ToInt32(dgvAllInvoices.CurrentRow.Cells["InvoiceID"].Value);
            double totalAmount = Convert.ToDouble(dgvAllInvoices.CurrentRow.Cells["TotalAmount"].Value);
            
            var frm = new frmPayInvoice(invoiceId, InvoiceStatus.FullyPaid , totalAmount);
            frm.ShowDialog();
        }

        private void payPartialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.PayInvoice))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            int invoiceId = Convert.ToInt32(dgvAllInvoices.CurrentRow.Cells["InvoiceID"].Value);
            double totalAmount = Convert.ToDouble(dgvAllInvoices.CurrentRow.Cells["TotalAmount"].Value);

            var frm = new frmPayInvoice(invoiceId, InvoiceStatus.PartiallyPaid, totalAmount);
            frm.ShowDialog();
        }

        private void paymentHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PermissionManager.HasInvoicePermission(InvoicePermissions.ViewInvoiceHistory))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            int invoiceId = Convert.ToInt32(dgvAllInvoices.CurrentRow.Cells["InvoiceID"].Value);
      
            var frm = new frmPaymentsHistory(invoiceId);
            frm.ShowDialog();
        }

        private void InvoicesMenu_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAllInvoices.CurrentRow != null)
            {
                string status = dgvAllInvoices.CurrentRow.Cells["Status"].Value?.ToString();

                if (status == "Fully Paid")
                {
                    payInvoiceToolStripMenuItem.Enabled = false;
                    applyDiscountToolStripMenuItem.Enabled = false;
                }else if (status == "Partially Paid")
                {
                    payFullToolStripMenuItem.Enabled = false;
                }
                else
                {
                    payInvoiceToolStripMenuItem.Enabled = true;
                    applyDiscountToolStripMenuItem.Enabled = true;
                }
            }
           
        }

        private void dgvAllInvoices_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvAllInvoices.ClearSelection();
                dgvAllInvoices.Rows[e.RowIndex].Selected = true;

                DataGridViewRow clickedRow = dgvAllInvoices.Rows[e.RowIndex];
                string status = clickedRow.Cells["Status"].Value?.ToString() ?? "";

                if (status == "Cancelled")
                {
                    dgvAllInvoices.ContextMenuStrip = null;
                }
                else
                {
                    dgvAllInvoices.ContextMenuStrip = InvoicesMenu;
                }
            }
        }

        private void dgvAllInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in dgvAllInvoices.Rows)
            {
                if (row.IsNewRow) continue;

                string value = row.Cells["Status"].Value.ToString();

                if (value == "Cancelled")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(224, 224, 244);
                }

            }
        }
    }
}
