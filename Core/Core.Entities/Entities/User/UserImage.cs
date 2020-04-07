using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class UserImage : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }
    }
}
