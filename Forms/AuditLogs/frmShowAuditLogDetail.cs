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

namespace HospitalManagementSystem.Forms.AuditLogs
{
    public partial class frmShowAuditLogDetail : Form
    {
        private int _LogID;
        AuditLogsService _AuditLogsService;
        public frmShowAuditLogDetail(int logID)
        {
            InitializeComponent();
            _LogID = logID;
            _AuditLogsService = new AuditLogsService();
        }

        private void frmShowAuditLogDetail_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            DataTable logDetail = _AuditLogsService.GetAuditLogByID(_LogID);

            if (logDetail == null) { 

                MessageBox.Show($"There is no Log with ID : {_LogID}.", "Not Exists",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblLogID.Text = logDetail.Rows[0]["AuditId"].ToString();
            lblDisplayName.Text = logDetail.Rows[0]["DisplayName"].ToString();
            lblPerformedBy.Text = logDetail.Rows[0]["PerformedBy"].ToString();
            lblAction.Text = logDetail.Rows[0]["Action"].ToString();
            lblEntityName.Text = logDetail.Rows[0]["EntityName"].ToString();
            lblRecordID.Text = logDetail.Rows[0]["EntityID"].ToString();
            DateTime createdAt = Convert.ToDateTime(logDetail.Rows[0]["CreatedAt"]);
            lblCreatedAt.Text = createdAt.ToString("MMM/dd/yyyy hh:mm:ss");
            lblOldValues.Text = logDetail.Rows[0]["OldValues"]?.ToString();
            lblNewValues.Text = logDetail.Rows[0]["NewValues"]?.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
