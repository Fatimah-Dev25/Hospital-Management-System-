using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models.Enums
{
    public enum GeneralPermissions
    {
        All = 1,
        PersonPermissions = 2,
        DoctorPermissions = 3,
        UsersPermissions = 4,
        AppointmentsPermissions = 5,
        BillingPermissions = 6,
        LabTestsPermissions = 7,
        LabTestsTypesPermissions = 8,
        MedicalRecordsPermissions = 9,
        PatientsPermissions = 10,
        PrescriptionsPermissions = 11,
        StaffPermissions = 12,
        LoggingAuditingPermissions = 13,
        UserRolesPermissions = 15

    }
}
