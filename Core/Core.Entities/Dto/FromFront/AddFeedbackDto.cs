using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class AddFeedbackDto
    {
        public Guid PartyId { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    }
}
