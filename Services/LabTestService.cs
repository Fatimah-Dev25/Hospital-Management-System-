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
using System.Windows.Forms;

namespace HospitalManagementSystem.Services
{
    public class LabTestService : ILabTestService
    {
        public TestTypeService _TestTypeService;

        public LabTestService()
        {
            _TestTypeService = new TestTypeService();
        }

        public int Add(LabTest entity, int userID = 0)
        {
            return LabTestRepository.AddNewLabTest(entity.MedicalRecordID, entity.TestTypeID, entity.TestDate,
                entity.Result, entity.Notes, entity.CreatedByUserID);
        }

        public bool Delete(int id, int userID)
        {
            return LabTestRepository.DeleteLabTest(id, userID);
        }

        public DataTable GetAll()
        {
            return LabTestRepository.GetLabTestsList();
        }

        public LabTest GetById(int id)
        {
            DataTable dt = LabTestRepository.GetLabTestInfoByID(id);
            
            if(dt != null)
            {
                return new LabTest
                {
                    LabTestID = Convert.ToInt32(dt.Rows[0]["ID"]),
                    MedicalRecordID = Convert.ToInt32(dt.Rows[0]["MedicalRecordID"]),
                    TestTypeID = Convert.ToInt32(dt.Rows[0]["TestTypeID"]),
                    TestDate = Convert.ToDateTime(dt.Rows[0]["TestDate"]),
                    Result = dt.Rows[0]["Result"].ToString(),
                    TestName = dt.Rows[0]["Test"].ToString(),
                    Notes = (!string.IsNullOrEmpty(dt.Rows[0]["Notes"].ToString())) ?
                      dt.Rows[0]["Notes"].ToString() : "",
                    CreatedByUserID = Convert.ToInt32(dt.Rows[0]["CreatedByUserID"])


                };
            }

            return null;
        }

        public DataTable GetLabTestsListFilterd(int? recordID = null, int? patientID = null)
        {
            return LabTestRepository.GetLabTestsListFilterd(recordID, patientID);
        }

        public bool Update(LabTest entity, int userID)
        {
            return LabTestRepository.UpdateLabTest(entity.TestDate, entity.Result, entity.LabTestID, userID ,entity.Notes);
        }

        public bool UpdateLabTestResult(int labTestId, string result, int userUD)
        {
            return LabTestRepository.UpdateLabTestResult(labTestId, result, userUD);
        }

        LabTest IRepository<LabTest>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<(int ID, string Type)> GetActiveTests()
        {
          return  _TestTypeService.GetAll()?.AsEnumerable()
                         .Where(row => row.Field<bool>("isActive") == true)
                         .Select(row => (
                             ID: row.Field<int>("TestTypeID"),
                             Type: row.Field<string>("TestName")
                             )
                         )
                         .ToList();
        }

        
    }
}
