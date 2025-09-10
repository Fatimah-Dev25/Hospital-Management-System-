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
    public class PrescriptionService : IPrescriptionService
    {
        MedicalRecordService recordService;

        public PrescriptionService()
        {

            recordService = new MedicalRecordService();
        }

        public int Add(Prescription entity, int userID = 0)
        {
            return PrescriptionRepository.AddPrescription(entity.MedicalRecordId, entity.PrescriptionText,
                entity.TotalPrice, entity.CreatedBy);
        }

        public bool Delete(int id, int deletedBy)
        {
            return PrescriptionRepository.DeletePrescription(id, deletedBy);
        }

        public DataTable GetAll()
        {
            return PrescriptionRepository.GetPrescriptionsList();
        }

        public Prescription GetById(int id)
        {
            var prscriptionDetail = PrescriptionRepository.GetPrescriptionByID(id);

            if (prscriptionDetail.Rows.Count > 0) {

                return new Prescription
                {

                    PrescriptionId = id,
                    MedicalRecordId = Convert.ToInt32(prscriptionDetail.Rows[0]["MedicalRecordId"]),
                    PrescriptionText = prscriptionDetail.Rows[0]["PrescriptionText"].ToString(),
                    TotalPrice = Convert.ToDouble(prscriptionDetail.Rows[0]["TotalPrice"]),
                    DateIssued = Convert.ToDateTime(prscriptionDetail.Rows[0]["DateIssued"]),
                    CreatedBy = Convert.ToInt32(prscriptionDetail.Rows[0]["CreatedBy"]),
                    PrescriptionFor = prscriptionDetail.Rows[0]["PatientName"].ToString(),
                    PrescriptionOrderBy = prscriptionDetail.Rows[0]["OrderbyDoctor"].ToString(),
                };
            }
     

            return null;
        }

        public DataTable GetPrescriptionsByPatientID(int patientID)
        {
            return PrescriptionRepository.GetPrescriptionsByPatientID(patientID);
        }

        public DataTable GetPrescriptionsByRecordID(int recordID)
        {
            return PrescriptionRepository.GetPrescriptionsByRecordID(recordID);
        }

        public bool Update(Prescription entity, int updatedBy)
        {
            return PrescriptionRepository.UpdatePrescription(entity.PrescriptionId, entity.PrescriptionText, entity.TotalPrice, updatedBy);
        }

        Prescription IRepository<Prescription>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<(string PatientName, string DoctorName)> GetSubRecordInfo(int recordID)
        {
            var record = MedicalRecordsRepository.GetRecordByID(recordID);

            return record?.AsEnumerable().
                Where(row => row.Field<int>("RecordID") == recordID).
                Select(row =>(
                  PatientName : row.Field<string>("PatientName"),
                  DoctorName : row.Field<string>("DoctorName")
                  )
                  ).ToList();
        }
    }
}
