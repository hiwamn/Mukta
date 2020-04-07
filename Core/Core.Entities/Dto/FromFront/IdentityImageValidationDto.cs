using System;

namespace Core.Entities.Dto
{
    public class IdentityImageValidationDto
    {
        public Guid UserId { get; set; }
        public bool IsAccepted{ get; set; }

    }
}
