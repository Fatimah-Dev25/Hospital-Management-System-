using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Newtonsoft.Json;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Forms.Prescriptions
{
    public partial class frmIssuePrescription : Form
    {
        enum enMode { IssueNew, Update}
        Prescription _PrescriptionEntity;
        private int _PrescriptionId;
        private int _RecordID;
        PrescriptionService _PrescriptionService;
        enMode _Mode;
        List<MedicationItem> _DrugsList;
        private int _DrugUpdateIndex = -1;

        public frmIssuePrescription(int recordID, int prescriptionID = -1)
        {
            _DrugsList = new List<MedicationItem>();
            _PrescriptionService = new PrescriptionService();
            _RecordID = recordID;
            InitializeComponent();

            if(prescriptionID > 0)
            {
                _Mode = enMode.Update;
                _PrescriptionId = prescriptionID;
            }
            else
            {
                _Mode = enMode.IssueNew;
            }

        }

        private void frmIssuePrescription_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            this.Text = "Update Prescription Details";
            _PrescriptionEntity = _PrescriptionService.GetById(_PrescriptionId);

            if (_PrescriptionEntity == null) { 
            
                MessageBox.Show($"There is no prescription with ID: {_PrescriptionId}..",
                    "Record Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

              this.Close();
                return;
                
            }

            lblPatientName.Text = _PrescriptionEntity.PrescriptionFor;
            lblDoctorName.Text = _PrescriptionEntity.PrescriptionOrderBy;
            lblPrescriptionID.Text = _PrescriptionEntity.PrescriptionId.ToString();
            lblDate.Text = _PrescriptionEntity.DateIssued.ToString("dddd,   MMM dd/yyyy");
            _DrugsList = JsonConvert.DeserializeObject<List<MedicationItem>>(_PrescriptionEntity.PrescriptionText);
            dgvDrugsList.DataSource = _DrugsList;
        }

        private void _ResetDrugDetail()
        {
            txtDrugName.Text = "";
            cbDosage.SelectedIndex = 0;
            cbDuration.SelectedIndex = 0;
            cbFrequency.SelectedIndex = 0;
            txtDrugPrice.Text = "";
        }
        private void _ResetDefaultValues()
        {
            lblPrescriptionID.Text = "[###]";
            if(_RecordID > 0 && _Mode == enMode.IssueNew)
            {
                var recoredInfo = _PrescriptionService.GetSubRecordInfo(_RecordID);

                lblPatientName.Text = recoredInfo[0].PatientName;
                lblDoctorName.Text = recoredInfo[0].DoctorName;
                lblDate.Text = DateTime.Now.ToString("dddd,   MMM dd/yyyy");
                this.Text = "Issue New Prescription";
                _PrescriptionEntity = new Prescription();
            }

            _ResetDrugDetail();

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            MedicationItem item = new MedicationItem();

            if (!_ValidateDrugInput())
            {
                MessageBox.Show("Please check the form. Some fields contain invalid or missing information.",
                         "Form Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            item.Drug = txtDrugName.Text;
            item.Dosage = cbDosage.Text;
            item.Frequency = cbFrequency.Text;
            item.Duration = cbDuration.Text;
            item.Price = Convert.ToDouble(txtDrugPrice.Text);

            _DrugsList.Add(item);
            _ResetDrugDetail();

            _BindDrugListToGrid();
        }

        private bool _ValidateDrugInput()
        {
            double price;

            bool CheckPrice = true;
          
            if(!double.TryParse(txtDrugPrice.Text, out price) || price <= 0)
{
                MessageBox.Show("Price must be a positive number.");
                CheckPrice =  false;
            }

            return
            !string.IsNullOrEmpty(txtDrugName.Text) &&
            !string.IsNullOrEmpty(txtDrugPrice.Text) &&
            !string.IsNullOrEmpty(cbDosage.Text) &&
            !string.IsNullOrEmpty(cbFrequency.Text) &&
            !string.IsNullOrEmpty(cbDuration.Text) && CheckPrice;
     
           
        }
        private void _BindDrugListToGrid()
        {
            dgvDrugsList.DataSource = null;
            dgvDrugsList.DataSource = _DrugsList;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_DrugsList.Count == 0)
            {
                MessageBox.Show("Please add at least one drug to the prescription.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _MapFormToModel();

            if(_Mode == enMode.IssueNew)
            {
                _PrescriptionEntity.PrescriptionId = _PrescriptionService.Add(_PrescriptionEntity);
                if (_PrescriptionEntity.PrescriptionId > 0)
                {
                    lblPrescriptionID.Text = _PrescriptionEntity.PrescriptionId.ToString();
                    _Mode = enMode.Update;
                    this.Text = "Update Prescription Detail";

                    MessageBox.Show("The prescription has been issued successfully.",
                        "Prescription Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("An error occurred while issuing the prescription.",
                                  "Failed to Issue Prescription",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
            else
            {
                if (_PrescriptionService.Update(_PrescriptionEntity, 1))
                {
                    MessageBox.Show(
                        "The prescription has been updated successfully.",
                        "Prescription Updated",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "An error occurred while updating the prescription. Please try again.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void _MapFormToModel()
        {
            double totalPrice = _DrugsList.Sum(d => d.Price);

            if (_Mode == enMode.IssueNew)
                _PrescriptionEntity.MedicalRecordId = _RecordID;
            
            _PrescriptionEntity.TotalPrice = totalPrice;
            _PrescriptionEntity.PrescriptionText = JsonConvert.SerializeObject(_DrugsList);
            _PrescriptionEntity.CreatedBy = 1;
        }

        private void toolUpdateDrug_Click(object sender, EventArgs e)
        {
            if (dgvDrugsList.CurrentRow == null)
                return;

            int index = dgvDrugsList.CurrentRow.Index;

            MedicationItem selectedItem = _DrugsList[index];

            txtDrugName.Text = selectedItem.Drug;
            cbDosage.Text = selectedItem.Dosage;
            cbFrequency.Text = selectedItem.Frequency;
            cbDuration.Text = selectedItem.Duration;
            txtDrugPrice.Text = selectedItem.Price.ToString();

            btnAddDrug.Visible = false;
            btnDrugUpdate.Visible = true;

            _DrugUpdateIndex = index;
        }

        private void btnDrugUpdate_Click(object sender, EventArgs e)
        {
            if(_DrugUpdateIndex >= 0)
            {
                _DrugsList[_DrugUpdateIndex].Drug = txtDrugName.Text; 
                _DrugsList[_DrugUpdateIndex].Price = Convert.ToDouble(txtDrugPrice.Text);
                _DrugsList[_DrugUpdateIndex].Dosage = cbDosage.Text;
                _DrugsList[_DrugUpdateIndex].Frequency = cbFrequency.Text;
                _DrugsList[_DrugUpdateIndex].Duration = cbDuration.Text;

                _DrugUpdateIndex = -1;
                _ResetDrugDetail();
                btnDrugUpdate.Visible = false;
                btnAddDrug.Visible = true;

                _BindDrugListToGrid();
            }
        }

        private void toolRemoveDrug_Click(object sender, EventArgs e)
        {
            if(dgvDrugsList.CurrentRow == null) return;

            int index = dgvDrugsList.CurrentRow.Index;
           
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this drug?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                _DrugsList.RemoveAt(index);
                _BindDrugListToGrid();
            }
        }

        private void txtDrugPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = (txtDrugPrice.Text.Contains("."));
            }
            else
            {
                e.Handled = true;
            }
        }

        private void llPrintPrescription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet.", "Not Implemented",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtDrugPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
