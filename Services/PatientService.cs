using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class PatientService : IPatientService
    {
        PersonService personService;

        public PatientService()
        {
            personService = new PersonService();
        }

        public int Add(Patient entity, int userID)
        {
            return PatientRepository.AddPatient(entity.PersonID, entity.FileNumber, entity.Allergies,
                entity.ChronicDiseases, (int)entity.Status, entity.BloodTypeID, userID);
        }

        public bool Delete(int id, int userID)
        {
            return PatientRepository.DeletePatient(id, userID);
        }

        public DataTable GetAll()
        {
            return PatientRepository.GetAllPatients();
        }

        public Patient GetById(int id)
        {
            DataTable patientDetail =  PatientRepository.GetPatientByID(id);
            if(patientDetail.Rows.Count > 0)
            {
                return new Patient
                {
                    PatientId = (int)patientDetail.Rows[0]["PatientID"],
                    Allergies = patientDetail.Rows[0]["Allergies"].ToString(),
                    ChronicDiseases = patientDetail.Rows[0]["ChronicDiseases"].ToString(),
                    Status = (Models.Enums.AdmissionStatus)Convert.ToInt32(patientDetail.Rows[0]["AdmissionStatus"]),
                    BloodTypeName = patientDetail.Rows[0]["BloodType"].ToString(),
                    FileNumber = patientDetail.Rows[0]["FileNumber"].ToString(),
                    PersonID = (int)patientDetail.Rows[0]["PersonID"],
                    RelatedPerson = personService.GetById((int)patientDetail.Rows[0]["PersonID"])
                };
            }
            return null;
        }

        public bool Update(Patient entity, int userID)
        {
            return PatientRepository.UpdatePatient(entity.Allergies, entity.ChronicDiseases, (int)entity.Status,
                entity.BloodTypeID, entity.PatientId, userID);
        }

        public bool CheckIfPatientExists(int personID)
        {
            return PatientRepository.IsPatientExistsForPerson(personID);
        }

        public int isPatientExits(int patientID = 0, string patientFile = null)
        {
            return PatientRepository.isPatientExits(patientID, patientFile);
        }

        public List<Patient> GetLatestPatients(int count = 5)
        {
            DataTable dt = PatientRepository.GetLatestPatients(count);

            if(dt != null && dt.Rows.Count > 0)
            {
                return dt.AsEnumerable().Select(row => new Patient
                { 
                    PatientId = row.Field<int>("PatientID"),
                    RelatedPerson = new Person
                    {
                        Fullname = row.Field<string>("Patient Name"),
                    } ,
                    FileNumber = row.Field<string>("FileNumber")
                }
                ).ToList();
            }

            return null;
        }
    }
}
