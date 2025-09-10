using HospitalManagementSystem.Models;
using HospitalManagementSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IAppointmentService: IRepository<Appointment>
    {
        bool UpdateAppointmentStatus(int appointmentID, AppointmentStatus appointmentStatus, int userID);

        DataTable GetAppointmentsFiltered(int? doctorID = null, DateTime? dateFrom = null, 
            DateTime? dateTo = null, int? patientID = null);

        List<string> GetBookedSlots(int doctorID, DateTime appointmentDate);

        bool AssignAppointmentToRecord(int appointmentID, int recordID, int userID);
    }
}
