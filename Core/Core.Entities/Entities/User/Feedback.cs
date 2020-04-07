using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Feedback : BaseEntity
    {
        public string Name { get; set; }
        public Guid  PartyId{ get; set; }
        public Party  Party{ get; set; }
        public int  Duration{ get; set; }
        public string Description{ get; set; }

        public int StatusId { get; set; }
        public EntityStatus Status { get; set; }
    }
}
