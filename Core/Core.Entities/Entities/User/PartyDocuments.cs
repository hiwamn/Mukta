using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class PartyDocuments : BaseEntity
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }
        
        public Guid PartyId { get; set; }
        public Party Party{ get; set; }


    }
}
