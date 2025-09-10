using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IBloodTypeService
    {
        List<(int ID, string Type)> GetAllBloodTypes();

        string GetBloodTypeByID(int bloodTypeId);
    }
}
