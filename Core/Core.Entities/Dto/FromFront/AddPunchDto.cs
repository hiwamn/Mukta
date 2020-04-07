using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class AddPunchDto
    {
        public Guid UserId { get; set; }
        public bool IsInput { get; set; }

    }
}
