using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Forms.Patients;
using HospitalManagementSystem.Models;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace HospitalManagementSystem.Forms
{
    public partial class frmDashboard : Form
    {
        AuditLogsService audiLogsService;
        PatientService patientService;
        public frmDashboard()
        {
            InitializeComponent();
            this.KeyPreview = true;
            audiLogsService = new AuditLogsService();
            patientService = new PatientService();
        
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _FillDataInCards();
            
            _SetupPatientChart();
            _SetLabTestsChart();
            _SetPatientsInDepartments();

            _LoadLatestPatients();
            _LoadSystemNews();
            _LoadHelpTips();
        }

        private void _LoadHelpTips()
        {
            var systemTips = General.GetSystemTips();

              lblHelptexts.Text = string.Join("",systemTips);

 
        }

        private void _LoadSystemNews()
        {
            lblSystemInfo.Text = string.Join("\n", General.GetSystemInfoAndNews());


            timer1.Interval = 70;
            timer1.Start();
        }

        private void _LoadLatestPatients()
        {
            var patients = patientService.GetLatestPatients();
            boxLatestPatients.Items.Clear();

            foreach (var patient in patients)
            {
                boxLatestPatients.Items.Add(patient);
            }

           
        }

        private void _SetPatientsInDepartments()
        {
            chartPatietsInDepartment.Series.Clear();
            chartPatietsInDepartment.ChartAreas.Clear();
            chartPatietsInDepartment.Titles.Clear();

            ChartArea chartArea = new ChartArea("MainArea");
            chartPatietsInDepartment.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "PatientsByDept",
                IsValueShownAsLabel = true,  
                ChartType = SeriesChartType.Doughnut
            };

            series.Points.AddXY("Cardiology", 15);
            series.Points.AddXY("Pediatrics", 35);
            series.Points.AddXY("Orthopedics", 30);
            series.Points.AddXY("Dermatology", 20);

            series.Points[0].Color = ColorTranslator.FromHtml("#7ccf00");
            series.Points[1].Color = ColorTranslator.FromHtml("#00bba7");
            series.Points[2].Color = ColorTranslator.FromHtml("#ff637e");
            series.Points[3].Color = ColorTranslator.FromHtml("#c27aff");

            chartPatietsInDepartment.Series.Add(series);


            foreach (var p in series.Points)
            {
                p.Label = "#PERCENT{P0}";   
                p.LegendText = "#VALX";
                p.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
            }

            series["PieLabelStyle"] = "Inside"; 
            series["PieDrawingStyle"] = "SoftEdge"; 
            chartPatietsInDepartment.Legends[0].Enabled = true;

            chartPatietsInDepartment.ChartAreas[0].Position.Width = 75;   
            chartPatietsInDepartment.ChartAreas[0].Position.Height = 75;  
            chartPatietsInDepartment.ChartAreas[0].Position.X = 10;        
            chartPatietsInDepartment.ChartAreas[0].Position.Y = 30;

            chartPatietsInDepartment.Titles.Add("Patients by Department");
            chartPatietsInDepartment.Titles[0].ForeColor = Color.FromArgb(29, 41, 61); 
            chartPatietsInDepartment.Titles[0].Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void _SetupPatientChart()
        {

           // var patientData = audiLogsService.GetPatinetsCountInMonth();
            var patientData = _GetPatinetsCountInMonth();

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };


            for (int i = 0; i < 12; i++)
            {
                var monthData = patientData.FirstOrDefault(x => x.MonthNumber == i + 1);
                int value = monthData != default ? monthData.NumberOfPatients : 0;

                if (chartTotalPatientsInYear.Series[0].Points.Count > i)
                    chartTotalPatientsInYear.Series[0].Points[i].YValues[0] = value;
                else
                    chartTotalPatientsInYear.Series[0].Points.AddXY(i + 1, value);

                if (chartTotalPatientsInYear.ChartAreas[0].AxisX.CustomLabels.Count < 12)
                    chartTotalPatientsInYear.ChartAreas[0].AxisX.CustomLabels.Add(i + 0.5, i + 1.5, months[i]);
            }

            chartTotalPatientsInYear.Legends[0].Enabled = false;

            foreach (var p in chartTotalPatientsInYear.Series[0].Points)
            {
                p.Label = p.YValues[0].ToString();
                p.LabelForeColor = Color.Black;
                p.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
            }

        }

        private List<(int MonthNumber, int NumberOfPatients)> _GetPatinetsCountInMonth()
        {
            return new List<(int, int)>
        {
            (1, 240), (2, 160), (3, 370), (4, 103), (5, 570), (6, 980),
            (7, 760), (8, 504), (9, 820), (10, 670), (11, 750), (12, 490)
        };
        }

        private void _FillDataInCards()
        {
            //postpone Revenus
            //(int todayPatients, int yesterdayPatients) patientsCard = audiLogsService.GetDashboardDetails("Patients",
            //    DateTime.Now.Date);

            (double todayPatients, double yesterdayPatients) patientsCard = (15,22);

            lblPatientsValue.Text = patientsCard.todayPatients.ToString();
            double patientsChangeValue = ((patientsCard.todayPatients - patientsCard.yesterdayPatients) / patientsCard.yesterdayPatients) * 100;
            lblChangePatientsValue.Text = patientsChangeValue >= 0? "+" + Math.Round(patientsChangeValue, 2) + "%":
                 Math.Round(patientsChangeValue, 2) + "%";


            //    (int todayAppoitments, int yesterdayAppointments) appointmentsCard = audiLogsService.GetDashboardDetails("Appointments",
            //DateTime.Now.Date);

            (double todayAppoitments, double yesterdayAppointments) appointmentsCard = (35, 73);

            lblAppointmentsValue.Text = appointmentsCard.todayAppoitments.ToString();
            double appointmentsChangeValue = ((appointmentsCard.todayAppoitments - appointmentsCard.yesterdayAppointments) / appointmentsCard.yesterdayAppointments) * 100;
            lblChangeAppointmentsValue.Text = appointmentsChangeValue >= 0 ? "+" + Math.Round(appointmentsChangeValue, 2) + "%" :
                Math.Round(appointmentsChangeValue,2) + "%";


            //    (int todayTests, int yesterdayTests) labTestsCard = audiLogsService.GetDashboardDetails("LabTests",
            //DateTime.Now.Date);

            (double todayTests, double yesterdayTests) labTestsCard = (124, 101);

            lblLabTestsValue.Text = labTestsCard.todayTests.ToString();
            double testsChangeValue = ((labTestsCard.todayTests - labTestsCard.yesterdayTests) / labTestsCard.yesterdayTests) * 100;
            lblChangeLabTestsValue.Text = testsChangeValue >= 0 ? "+" + Math.Round(testsChangeValue,2) + "%" :
                Math.Round(testsChangeValue,2) + "%";


            //    (int todayInvoices, int yesterdayInvoices) invoicesCard = audiLogsService.GetDashboardDetails("Invoices",
            //DateTime.Now.Date);

            (double todayInvoices, double yesterdayInvoices) invoicesCard = (67, 48);

            lblInvoicesValue.Text = invoicesCard.todayInvoices.ToString();
            double invoicesChangeValue = ((invoicesCard.todayInvoices - invoicesCard.yesterdayInvoices) / invoicesCard.yesterdayInvoices) * 100;
            lblChangeInvoicesValue.Text = invoicesChangeValue >= 0 ? "+" + Math.Round(invoicesChangeValue, 2) + "%" :
                Math.Round(invoicesChangeValue,2) + "%";

            //postpone Revenues
            (double todayRevenues, double yesterdayRevenues) revenuesCard = (28450, 22410);

            lblRevenuesValue.Text = revenuesCard.todayRevenues.ToString() + " $.";
            double revenuesChangeValue = ((revenuesCard.todayRevenues - revenuesCard.yesterdayRevenues) / revenuesCard.yesterdayRevenues) * 100;
            lblRevenusChangeValues.Text = revenuesChangeValue >= 0 ? "+" + Math.Round(revenuesChangeValue,2) + "%" :
                Math.Round(revenuesChangeValue,2) + "%";

        }

     
        private void _SetLabTestsChart()
        {
            var data = _GetInitialTestData();
            chartTestsPerDepartment.Series[0].Points.Clear();

            foreach (var item in data)
            {
                chartTestsPerDepartment.Series[0].Points.AddXY(item.Department, item.TestCount);
            }

            chartTestsPerDepartment.Legends[0].Enabled = false;


            chartTestsPerDepartment.Series[0].Points[0].Color = ColorTranslator.FromHtml("#00d492"); 
            chartTestsPerDepartment.Series[0].Points[1].Color = ColorTranslator.FromHtml("#7c86ff"); 
            chartTestsPerDepartment.Series[0].Points[2].Color = ColorTranslator.FromHtml("#ed6aff"); 
            chartTestsPerDepartment.Series[0].Points[3].Color = ColorTranslator.FromHtml("#9ae600"); 
            chartTestsPerDepartment.Series[0].Points[4].Color = ColorTranslator.FromHtml("#ffb900"); 
            chartTestsPerDepartment.Series[0].Points[5].Color = ColorTranslator.FromHtml("#ff6467");

            foreach (var p in chartTestsPerDepartment.Series[0].Points)
            {
                p.Label = p.YValues[0].ToString();
                p.LabelForeColor = Color.Black;
                p.Font = new System.Drawing.Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

        private List<(string Department, int TestCount)> _GetInitialTestData()
        {
            return new List<(string Department, int TestCount)>
                 {
                     ("Laboratory", 4900),
                     ("Radiology", 2050),
                     ("Cardiology", 1900),
                     ("Emergency", 3500),
                     ("Pediatrics", 1420),
                     ("Orthopedics", 3600),
                     ("Intensive Care Unit (ICU)", 1040)
                 };
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boxLatestPatients_DoubleClick(object sender, EventArgs e)
        {
            if (boxLatestPatients.SelectedItem is Patient selectedPatient)
            {
                int patientId = selectedPatient.PatientId;
                var detailForm = new frmPatientDetail(patientId);
                detailForm.Show();
            }
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSystemInfo.Top -= 1; 

            if (lblSystemInfo.Bottom < 0)
            {
                lblSystemInfo.Top = panelSystemInfo.Height;
            }
        }

        private void frmDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                var frm = new frmAddEditPatient();
                frm.ShowDialog();
                e.Handled = true; 
            }
        }
    }
}
