using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class BloodTypeService : IBloodTypeService
    {
        public List<(int ID, string Type)> GetAllBloodTypes()
        {
            return BloodTypeRepository.GetAllBloodTypes();
        }

        public string GetBloodTypeByID(int bloodTypeId)
        {
            return BloodTypeRepository.GetBloodTypeByID(bloodTypeId);
        }
    }
}
