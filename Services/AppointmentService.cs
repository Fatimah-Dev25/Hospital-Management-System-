using DocumentFormat.OpenXml.Drawing.Charts;
using HospitalManagementSystem.Data;
using HospitalManagementSystem.Interfaces;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using HospitalManagementSystem.Utilities.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;

namespace HospitalManagementSystem.Services
{
    public class AppointmentService : IAppointmentService
    {
        DoctorService doctorService;
        DepartmentService departmentService;
        PatientService patientService;
        MedicalRecordService recordService;

        public AppointmentService()
        {
            patientService = new PatientService();
            doctorService = new DoctorService();
            departmentService = new DepartmentService();
            recordService = new MedicalRecordService();
        }

        public int Add(Appointment entity, int userID = 0)
        {
            return AppointementRepository.AddAppointment(entity.PatientID, entity.DoctorID, entity.AppointmentDate,
                entity.AppointmentTime,(int)entity.AppointmentStatus, (int)entity.AppointmentType, entity.Notes, entity.CreatedByUserID);
        }

        public bool Delete(int id, int userID)
        {
            return AppointementRepository.DeleteAppointment(id, userID);
        }

        public DataTable GetAll()
        {
            return AppointementRepository.GetAppointmentsList();

        }

        public DataTable GetAppointmentsFiltered(int? doctorID = null, DateTime? dateFrom = null,
            DateTime? dateTo = null, int? patientID = null)
        {
            return AppointementRepository.GetAppointmentsFiltered(doctorID, dateFrom, dateTo, patientID);
        }

        public Appointment GetById(int id)
        {
            DataTable dt = AppointementRepository.GetAppointmentByID(id);
            return new Appointment { 
            
                AppointementID = Convert.ToInt32(dt.Rows[0]["AppointementID"]),
                AppointmentDate = Convert.ToDateTime(dt.Rows[0]["AppointmentDate"]),
                AppointmentTime = (TimeSpan)TimeSpan.Parse(dt.Rows[0]["TimeSlot"].ToString()),
                AppointmentStatus = (Models.Enums.AppointmentStatus)(Convert.ToInt32(dt.Rows[0]["Status"])),
                AppointmentType = (Models.Enums.AppointmentType)(Convert.ToInt32(dt.Rows[0]["AppointmentType"])),
                DoctorName = dt.Rows[0]["DoctorName"].ToString(),
                Department = dt.Rows[0]["Department"].ToString(),
                PatientName = dt.Rows[0]["PatientName"].ToString(),
                PatientFile = dt.Rows[0]["FileNumber"].ToString(),
                PatientID = Convert.ToInt32(dt.Rows[0]["PatientID"]),
                DoctorID = Convert.ToInt32(dt.Rows[0]["DoctorID"]),
                Notes = dt.Rows[0]["Notes"] == DBNull.Value ? null : dt.Rows[0]["Notes"].ToString()

            };

            return null;
        }

        public bool Update(Appointment entity, int updateBy)
        {
            return AppointementRepository.UpdateAppointment(entity.AppointementID, entity.AppointmentDate,
                entity.AppointmentTime, entity.DoctorID,(int)entity.AppointmentStatus, (int)entity.AppointmentType, entity.Notes, updateBy);
        }

        public bool UpdateAppointmentStatus(int appointmentID, AppointmentStatus appointmentStatus, int updateBy)
        {
            return AppointementRepository.UpdateAppointmentStatus(appointmentID, (int)appointmentStatus, updateBy);
        }

        public List<(int id, string name, string Dept)> GetAllDoctors()
        {
            return doctorService.GetAll()?.AsEnumerable()
                .Select(row => (
                id: row.Field<int>("DoctorID"),
                name: row.Field<string>("Fullname"),
                Dept: row.Field<string>("Department") 
                )
                ).ToList();
        }

        public List<(int id, string name)> GetDepartments()
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


        public List<string> GetBookedSlots(int doctorID, DateTime appointmentDate)
        {

            return AppointementRepository.GetBookedSlots(doctorID, appointmentDate);
        }

        public int isPersonExits(int patientID = 0, string patientFile = null)
        {
            return patientService.isPatientExits(patientID, patientFile);
        }

        public bool AssignAppointmentToRecord(int appointmentID, int recordID, int userID)
        {
            return AppointementRepository.LinkAppointmentToRecord(appointmentID, recordID, userID);
        }

        public bool IsRecordExits(int recordID) {
        
            return recordService.CheckRecordExits(recordID);
        }

        
    }
}
