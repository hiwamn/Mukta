using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class EditFeedbackDto
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
    }
}
