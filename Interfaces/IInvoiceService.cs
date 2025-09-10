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
    public interface IInvoiceService
    {
        DataTable GetAllInvoices();
        DataTable GetInvoicesByPatientID(int patientID);
        Invoice GetInvoiceInfoById(int invoiceID);
        DataTable GetInvoicesByMedicalRecord(int recordID);
        int AddInvoice(Invoice entity, int userID);
        bool DeleteInvoice(int invoiceID, int userID);
        bool UpdateInvoiceInfo(Invoice entity, int userID);
        DataTable GetInvoiceItems(int invoiceID);
        Patient GetPatientInfoByInvoiceID(int invoiceID);
        InvoiceItem GetInvoiceItemDetailByID(int invoiceItemID);
        bool UpdateInvoiceItemByID(InvoiceItem invoiceItem, int userID);
        bool DeleteInvoiceItem(int invoiceItemID, int userID);
 
        bool UpdateInvoiceStatus(int invoiceId, int status, int userID);    
        bool UpdateInvoiceDescription(int invoiceId, string description, int userID);

        int PerformInvoice(Payment payment, InvoiceStatus invoceStatus);

        DataTable GetInvoicePayments(int invoiceID);
    }

}
