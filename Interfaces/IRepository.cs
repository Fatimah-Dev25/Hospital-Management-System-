using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IRepository<T>
    {
        int Add(T entity, int userID = 0);
        bool Update(T entity, int userID = 0);
        bool Delete(int id, int userID = 0);
        T GetById(int id);
        DataTable GetAll();
    }
}
