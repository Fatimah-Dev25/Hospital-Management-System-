using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Utilities.Services
{
    public class DoctorService : IDoctorService
    {
        PersonService personService;
        DepartmentService departmentService;


        public int Add(Doctor entity,int userID)
        {
            return DoctorRepository.AddDoctor(entity.Specialization, entity.ExperienceYears,
                entity.DateHired, entity.PersonID, entity.DepartmentID, userID);

        }

      

        public DoctorService()
        {
            personService = new PersonService();
            departmentService = new DepartmentService();
        }

        public bool Delete(int id, int userID)
        {
            return DoctorRepository.DeleteDoctor(id, userID);
        }

        public DataTable GetAll()
        {
            return DoctorRepository.GetDoctorsList();
        }

        public Doctor GetById(int id)
        {
            var doctorDetail =  DoctorRepository.GetDoctorByID(id);

            if (doctorDetail != null) {

                return new Doctor
                {
                    DoctorID = (int)doctorDetail.Rows[0]["DoctorID"],
                    PersonID = (int)doctorDetail.Rows[0]["PersonID"],
                    Specialization = doctorDetail.Rows[0]["Specialization"].ToString(),
                    ExperienceYears = (int)doctorDetail.Rows[0]["ExperienceYears"],
                    DateHired = Convert.ToDateTime(doctorDetail.Rows[0]["DateHired"]),
                    DepartmentID = (int)doctorDetail.Rows[0]["DepartmentID"],
                    RelatedPerson = personService.GetById((int)doctorDetail.Rows[0]["PersonID"]),
                    DepartmentTilte = doctorDetail.Rows[0]["Department"].ToString()

                };
            }

            return null;
        }

        public DataTable GetDepartementDoctors(int DeptID)
        {
            return DoctorRepository.GetDepartementDoctors(DeptID);
        }

        public bool Update(Doctor entity, int userID)
        {
            return DoctorRepository.UpdateDoctor(entity.DoctorID, entity.Specialization, entity.ExperienceYears,
               entity.DateHired, entity.DepartmentID, userID);
        }

        public List<(int id, string department)> GetMedicalDepartmentsOnly()
        {
            
            return departmentService.GetAll()?.AsEnumerable()
                .Where(row => row.Field<string>("DepartmentType") == "Medical")
                .Select(row => (
                    id: row.Field<int>("DeptID"),
                    department: row.Field<string>("Department")
                    )
                )
                .ToList();
        }

        public bool isDoctorExistsForPerson(int personID)
        {
            return DoctorRepository.IsDoctorExistsForPerson(personID);
        }

        public List<int> GetDoctorsID()
        {
            return DoctorRepository.GetDoctorsID().AsEnumerable()
             .Select(row => row.Field<int>("DoctorID"))
             .ToList(); 
        }
    }
}
