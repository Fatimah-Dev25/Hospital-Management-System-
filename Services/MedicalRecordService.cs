using DocumentFormat.OpenXml.ExtendedProperties;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        InvoiceService invoiceService;

        public MedicalRecordService()
        {
            invoiceService = new InvoiceService();
        }

        public int IssueRecord(MedicalRecord entity, int appointmentID)
        {
            return MedicalRecordsRepository.AddPatientRecord(entity.PatientID, entity.DoctorID, entity.Diagnosis,
                entity.Treatment, entity.CreatedByUserID, appointmentID, entity.Notes);

        }

        private int Add(MedicalRecord entity, int user = 0)
        {
            return 0;
        }

        public bool CheckRecordExits(int recordID)
        {
            return MedicalRecordsRepository.CheckRecordExists(recordID);
        }

        public bool CheckRecordHasActiveAppoitment(int recordID)
        {
            return MedicalRecordsRepository.HasActiveAppointment(recordID);
        }

        public bool Delete(int id, int userID)
        {
            return MedicalRecordsRepository.DeleteRecord(id, userID);
        }

        public DataTable GetAll()
        {
            return MedicalRecordsRepository.GetMedicalRecordsList();
        }

        public MedicalRecord GetById(int id)
        {
            var recordDetail = MedicalRecordsRepository.GetRecordByID(id);

            if (recordDetail != null)
            {
                return new MedicalRecord
                {
                    RecordID = Convert.ToInt32(recordDetail.Rows[0]["RecordID"]),
                    PatientName = recordDetail.Rows[0]["PatientName"].ToString(),
                    DoctorName = recordDetail.Rows[0]["DoctorName"].ToString(),
                    Department = recordDetail.Rows[0]["Department"].ToString(),
                    Diagnosis = recordDetail.Rows[0]["Diagnosis"].ToString(),
                    Treatment = recordDetail.Rows[0]["Treatment"].ToString(),
                    Notes = string.IsNullOrEmpty(recordDetail.Rows[0]["Notes"].ToString()) ?
                        "" : recordDetail.Rows[0]["Notes"].ToString(),
                    
                    RecordDate = Convert.ToDateTime(recordDetail.Rows[0]["RecordDate"])
                    
                };
            }

            return null;
        }

        public DataTable GetPatientRecords(int patientID)
        {
            return MedicalRecordsRepository.GetPatientRecords(patientID);
        }

        public bool Update(MedicalRecord entity, int userID)
        {
            return MedicalRecordsRepository.UpdateRecord(entity.RecordID, entity.Diagnosis, entity.Treatment, userID ,entity.Notes);
        }

   
        public int GenerateInvoice(int recordID, int userID)
        {
            Invoice newInvoice = new Invoice();
            newInvoice.MedicalRecordID = recordID;
            newInvoice.Status = Models.Enums.InvoiceStatus.Unpaid;

            return invoiceService.AddInvoice(newInvoice, userID);

        }

        int IRepository<MedicalRecord>.Add(MedicalRecord entity, int u)
        {
            return Add(entity, u);
        }
    }
}
