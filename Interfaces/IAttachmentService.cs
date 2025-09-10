using HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Interfaces
{
    public interface IAttachmentService
    {
        DataTable GetAllAttachments();
        DataTable GetAttachmentByRelatdInfo(string relatedTable, int recordID);
        DataTable GetAttachmentByID(int attachmentID);
        int AddAttachment(Attachment entity, int createdBy);
        bool DeleteAttachmentByRelatedInfo(string relatedTable, int relatedRecord, int deletedBy);
        bool DeleteAttachmentByID(int attachmentID, int deletedBy);
        bool UpdateAttachment(Attachment entity, int updatedBy);
    }
}
