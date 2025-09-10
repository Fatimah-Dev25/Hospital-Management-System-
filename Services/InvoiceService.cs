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
    public class InvoiceService : IInvoiceService
    {
        public int AddInvoice(Invoice entity, int userID)
        {
            return InvoicesRepository.IssueInvoic(entity.MedicalRecordID, entity.ServiceDescription, (int)entity.Status, userID);
        }

        public bool DeleteInvoice(int invoiceID, int userID)
        {
            return InvoicesRepository.DeleteInvoice(invoiceID, userID);
        }

        public bool DeleteInvoiceItem(int invoiceItemID, int userID)
        {
            return InvoicesRepository.DeleteInvoiceItemByID(invoiceItemID, userID);
        }

        public DataTable GetAllInvoices()
        {
            return InvoicesRepository.GetInvoicesList();
        }

        public Invoice GetInvoiceInfoById(int invoiceID)
        {
            DataTable dt = InvoicesRepository.GetInvoiceDetailById(invoiceID);
       
            if(dt != null)
            {
                return new Invoice
                {
                    InvoiceID = Convert.ToInt32(dt.Rows[0]["InvoiceID"]),
                    MedicalRecordID = Convert.ToInt32(dt.Rows[0]["RecordID"]),
                    ServiceDescription =dt.Rows[0]["ServiceDescription"].ToString(),
                    TotalAmount = Convert.ToDouble((decimal)dt.Rows[0]["TotalAmount"]),
                    InvoiceIssuedDate = Convert.ToDateTime(dt.Rows[0]["BillingDate"]),
                    Status = (InvoiceStatus)(Convert.ToInt32(dt.Rows[0]["Status"])),
                    isDelete = Convert.ToBoolean(dt.Rows[0]["isDelete"])
                };
            }
            return null;
        }

        public InvoiceItem GetInvoiceItemDetailByID(int invoiceItemID)
        {
            var dt = InvoicesRepository.GetInvoiceItemInfoByID(invoiceItemID);

            if( dt != null)
            {
                return new InvoiceItem
                {
                    InvoiceItemID = Convert.ToInt32(dt.Rows[0]["InvoiceDetailID"]),
                    InvoiceID = Convert.ToInt32(dt.Rows[0]["InvoiceID"]),
                    ItemID = Convert.ToInt32(dt.Rows[0]["ItemID"]),
                    ItemType = dt.Rows[0]["ItemType"].ToString(),
                    Description = dt.Rows[0]["Description"].ToString(),
                    Price = Convert.ToDouble((decimal)dt.Rows[0]["TotalPrice"])
                };
            }
            return null;
        }

        public DataTable GetInvoiceItems(int invoiceID)
        {
            return InvoicesRepository.GetInvoiceItems(invoiceID);
        }

        public DataTable GetInvoicePayments(int invoiceID)
        {
            return InvoicesRepository.GetInvoicePaymentsList(invoiceID);
        }

        public DataTable GetInvoicesByMedicalRecord(int recordID)
        {
            return InvoicesRepository.GetInvoicesByMedicalRecord(recordID);
        }

        public DataTable GetInvoicesByPatientID(int patientID)
        {
            return InvoicesRepository.GetInvoicesByPatientID(patientID);
        }
        public Patient GetPatientInfoByInvoiceID(int invoiceID)
        {
            DataTable dt = InvoicesRepository.GetPatientInfoByInvoiceID(invoiceID);
        
            if(dt != null)
            {
                return new Patient
                {
                    RelatedPerson = new Person
                    {
                        Fullname = dt.Rows[0]["FullName"].ToString(),
                        BirthDate = Convert.ToDateTime(dt.Rows[0]["DateOfBirth"]),
                        Gender = (GenderType)(Convert.ToChar(dt.Rows[0]["Gender"])),
                        Phone = dt.Rows[0]["Phone"].ToString(),
                        Address = dt.Rows[0]["Address"].ToString()
                    },
                    Status = (AdmissionStatus)(Convert.ToInt16(dt.Rows[0]["AdmissionStatus"])),
                    FileNumber = dt.Rows[0]["FileNumber"].ToString()
                };
            }

            return null;
        }

        public int PerformInvoice(Payment payment, InvoiceStatus invoceStatus)
        {
            return InvoicesRepository.PerformPayment(payment.InvoiceID, (int)invoceStatus, payment.AmountPaid, (int)payment.PaymentMethod, payment.EnteredByID);
        }

        public bool UpdateInvoiceDescription(int invoiceId, string description, int userID)
        {
            return InvoicesRepository.UpdateInvoiceDescriptionByID(invoiceId, description, userID);
        }

        public bool UpdateInvoiceInfo(Invoice entity, int userID)
        {
      
          return InvoicesRepository.UpdateInvoiceInfo(entity.InvoiceID, entity.TotalAmount, userID, entity.ServiceDescription);
        }

        public bool UpdateInvoiceItemByID(InvoiceItem invoiceItem, int userID)
        {
            return InvoicesRepository.UpdateInvoiceItemByID(invoiceItem.InvoiceItemID,
                invoiceItem.ItemType, invoiceItem.Description, invoiceItem.Price, userID);
        }

        public bool UpdateInvoiceStatus(int invoiceId, int status, int userID)
        {
            return InvoicesRepository.UpdateInvoiceStatusByID(invoiceId, status, userID);
        }
    }
}
