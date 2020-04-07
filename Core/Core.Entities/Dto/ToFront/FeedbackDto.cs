
using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class FeedbackDto
    {
        public PartyDto Party{ get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public string Name { get; internal set; }
    }

   
}
