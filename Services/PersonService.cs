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
    public class PersonService : IPersonService
    {
        public int Add(Person entity, int userID)
        {
            return PersonRepository.AddPerson(entity.Fullname, entity.BirthDate, entity.Phone, 
                entity.Email, (char)entity.Gender, entity.Address, entity.ImagePath, userID);
        }

        public bool Delete(int id, int userID)
        {
            return PersonRepository.DeletePerson(id, userID);
        }

        public DataTable GetAll()
        {
            return PersonRepository.GetAllPeople();
        }

        public Person GetById(int id)
        {
            DataTable personDetail = PersonRepository.GetPersonByID(id);
           
            if (personDetail != null) {

                return new Person
                {
                    PersonID = (int)personDetail.Rows[0]["PersonID"],
                    Fullname = personDetail.Rows[0]["Fullname"].ToString(),
                    Phone = personDetail.Rows[0]["Phone"].ToString(),
                    Email = personDetail.Rows[0]["Email"].ToString(),
                    Address = personDetail.Rows[0]["Address"].ToString(),
                    BirthDate = Convert.ToDateTime(personDetail.Rows[0]["DateOfBirth"]),
                    Gender = (personDetail.Rows[0]["Gender"].ToString() == "M") ? GenderType.Male : GenderType.Female,
                    ImagePath = personDetail.Rows[0]["Image"].ToString()
                };
            }

            return null;
        }

        public Person GetByName(string name)
        {
            DataTable personDetail = PersonRepository.GetPersonByName(name);

            if (personDetail.Rows.Count > 0)
            {

                return new Person
                {
                    PersonID = (int)personDetail.Rows[0]["PersonID"],
                    Fullname = personDetail.Rows[0]["Fullname"].ToString(),
                    Phone = personDetail.Rows[0]["Phone"].ToString(),
                    Email = personDetail.Rows[0]["Email"].ToString(),
                    Address = personDetail.Rows[0]["Address"].ToString(),
                    BirthDate = Convert.ToDateTime(personDetail.Rows[0]["DateOfBirth"]),
                    Gender = (personDetail.Rows[0]["Gender"].ToString() == "M") ? GenderType.Male : GenderType.Female,
                    ImagePath = personDetail.Rows[0]["Image"].ToString()
                };
            }
            return null;
        }

        public bool Update(Person entity, int userID)
        {
            return PersonRepository.UpdatePerson(entity.PersonID, entity.Fullname, entity.BirthDate,
                entity.Phone, entity.Email, (char)entity.Gender, entity.Address, entity.ImagePath, userID);
        }
    }
}
