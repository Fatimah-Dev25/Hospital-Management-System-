using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Attachment
    {
        public int AttachmentID { get; set; }
        public string RelatedTable { get; set; }
        public int RelatedRecord {  get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }        

        public DateTime UpdatedAt { get; set; }

    }
}
