using DocumentFormat.OpenXml.Office2010.PowerPoint;
using DocumentFormat.OpenXml.Wordprocessing;
using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Services;
using HospitalManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using PageSize = DocumentFormat.OpenXml.Wordprocessing.PageSize;

namespace HospitalManagementSystem.Forms.AuditLogs
{
    public partial class frmAuditLogsManagement : Form
    {


        private AuditLogsService auditLogsService;

        private DataTable _Logs;
        public frmAuditLogsManagement()
        {
            InitializeComponent();

            auditLogsService = new AuditLogsService();


        }

        private void frmAuditLogsManagement_Load(object sender, EventArgs e)
        {
            _Logs = auditLogsService.GetAuditLogsList();
            dgvSystemAuditLogs.DataSource = _Logs;

            dgvSystemAuditLogs.Columns[0].Width = 120;
            dgvSystemAuditLogs.Columns[1].Width = 150;
            dgvSystemAuditLogs.Columns[2].Width = 260;
            dgvSystemAuditLogs.Columns[3].Width = 170;
            dgvSystemAuditLogs.Columns[4].Width = 190;
            dgvSystemAuditLogs.Columns[5].Width = 150;
            dgvSystemAuditLogs.Columns[6].Width = 220;

            cbFilterBy.SelectedIndex = 0;

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = cbFilterBy.Text != "None" && cbFilterBy.Text != "Action Date";
            FilterByDate.Visible = cbFilterBy.Text == "Action Date";

            if (cbFilterBy.SelectedIndex == 0)
                _Logs.DefaultView.RowFilter = "";

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string columnFilter = "";

            switch (cbFilterBy.Text)
            {
                case "None":
                    columnFilter = "None";
                    break;

                case "Performed By":
                    columnFilter = "PerformedBy";
                    break;

                case "Table Name":
                    columnFilter = "EntityName";
                    break;

                case "Action":
                    columnFilter = "Action";
                    break;
            }

            if (columnFilter == "None" || string.IsNullOrEmpty(txtFilterBy.Text))
            {

                _Logs.DefaultView.RowFilter = "";
                return;
            }
            else
            {
                _Logs.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", columnFilter,
                                  txtFilterBy.Text.Trim());
            }
        
        }

        private void FilterByDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = FilterByDate.Value.Date;
            DateTime nextDate = selectedDate.AddDays(1);

            _Logs.DefaultView.RowFilter =
                $"CreatedAt >= #{selectedDate:yyyy-MM-dd}# AND CreatedAt < #{nextDate:yyyy-MM-dd}#";

        }

        private void dgvSystemAuditLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!PermissionManager.HasAuiditLogsPermission(AuditLogsPermissions.ViewLogDetail))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            if (e.RowIndex >= 0)
            {
                int auditlogID = Convert.ToInt32(dgvSystemAuditLogs.Rows[e.RowIndex].Cells["AuditId"].Value);

                var frm = new frmShowAuditLogDetail(auditlogID);
                frm.ShowDialog();   
            }
        }

        private void btnExport2Excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
           
            sfd.Filter = "Excel File|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(_Logs, sfd.FileName); 
            }
        }


        private void ExportToExcel(DataTable dt, string filePath)
        {
            if (!PermissionManager.HasAuiditLogsPermission(AuditLogsPermissions.ExportToPDF))
            {
                MessageBox.Show(
                "You don’t have permission to perform this action.",
                "Permission Denied",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
                return;

            }
            try
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedData";

                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }

                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Exported to Excel successfully ✅");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during export: " + ex.Message);
            }
        }

      
    }
}
