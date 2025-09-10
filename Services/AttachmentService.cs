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
    public class AttachmentService : IAttachmentService
    {
        public int AddAttachment(Attachment entity, int createdBy)
        {
            return AttachmentsRepository.AddAttachment(entity.RelatedTable, entity.RelatedRecord,entity.FileName,
                entity.FilePath, createdBy);
        }

        public bool DeleteAttachmentByID(int attachmentID, int deletedBy)
        {
            return AttachmentsRepository.DeleteAttachmentByID(attachmentID, deletedBy);
        }

        public bool DeleteAttachmentByRelatedInfo(string relatedTable, int relatedRecord, int deletedBy)
        {
            return AttachmentsRepository.DeleteAttachmentByRelatedInfo(relatedTable, relatedRecord, deletedBy);
        }

        public DataTable GetAllAttachments()
        {
            return AttachmentsRepository.GetAllAttachments();
        }

        public DataTable GetAttachmentByID(int attachmentID)
        {
            return AttachmentsRepository.GetAttachmentByID(attachmentID);
        }

        public DataTable GetAttachmentByRelatdInfo(string relatedTable, int recordID)
        {
            return AttachmentsRepository.GetAttachmentByRelatedInfo(relatedTable, recordID);
        }

        public bool UpdateAttachment(Attachment entity, int updatedBy)
        {
            return AttachmentsRepository.UpdateAttachment(entity.AttachmentID, entity.FileName,
                entity.FilePath, updatedBy);
        }
    }
}
