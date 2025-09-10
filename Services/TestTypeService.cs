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
    public class TestTypeService : ITestTypeService
    {
        public int Add(TestType entity, int userID)
        {
            return LabTestTypeRepository.AddNewTestType(entity.TestTypeName, entity.Description, entity.Price, entity.isActive, userID);
        }

        public bool ChangeTestTypeActivation(int testTypeID, bool isActive, int userID)
        {
            return LabTestTypeRepository.ChangeTestTypeActivation(testTypeID, isActive, userID);
        }

        public bool Delete(int id, int userID)
        {
            return LabTestTypeRepository.DeleteTestType(id, userID);
        }

        public TestType GetById(int id)
        {
            DataTable dt = LabTestTypeRepository.GetTestTypeByID(id);

            if (dt != null)
            {
                return new TestType
                {
                    TestTypeID = Convert.ToInt32(dt.Rows[0]["TestTypeID"]),
                    TestTypeName = dt.Rows[0]["TestName"].ToString(),
                    Price = Convert.ToDouble(dt.Rows[0]["Price"]),
                    isActive = Convert.ToBoolean(dt.Rows[0]["isActive"]),
                    Description = (string.IsNullOrEmpty(dt.Rows[0]["Description"].ToString())) ?
                          "" : dt.Rows[0]["Description"].ToString()
                };
            }

            return null;
        }

        public List<TestType> GetTypesList()
        {
            return LabTestTypeRepository.GetTestTypesList()?.AsEnumerable()
                            .Select(row => new TestType{
                                TestTypeID = row.Field<int>("TestTypeID"),
                                TestTypeName =  row.Field<string>("TestName"),
                                Price = Convert.ToDouble(row.Field<decimal>("Price")),
                                isActive = row.Field<bool>("isActive")
                            }).ToList();
        }

        public bool Update(TestType entity, int userID)
        {
            return LabTestTypeRepository.UpdateTestType(entity.TestTypeID, entity.TestTypeName, entity.Description,entity.Price ,entity.isActive, userID);
        }

        public DataTable GetAll()
        {
            return LabTestTypeRepository.GetTestTypesList();
        }
    }
}
