using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class OrderDocuments : BaseEntity
    {
        public Guid DocumentId { get; set; }
        public Document Document { get; set; }

        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
