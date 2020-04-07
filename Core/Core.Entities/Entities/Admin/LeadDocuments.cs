using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class LeadDocuments : BaseEntity
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }
        
        public Guid LeadId { get; set; }
        public Lead Lead { get; set; }


    }
}
