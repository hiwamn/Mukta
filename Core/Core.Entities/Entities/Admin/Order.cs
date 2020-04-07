using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Order : BaseEntity
    {
        public string Name{ get; set; }
        public int SlNo{ get; set; }
        public string ItemCode { get; set; }
        public string Description{ get; set; }
        public string Quantity{ get; set; }
        public string RatePerUnit{ get; set; }
        public string Discount{ get; set; }
        public string NetPrice{ get; set; }
        public string SaleTax{ get; set; }
        public string DeliveryPeriod{ get; set; }
        public string Days{ get; set; }
        public string DayCount { get; set; }
        public bool PaymentTerms{ get; set; }
        public bool Insurance{ get; set; }
        public long PurchaseOrderValidityDate{ get; set; }

        public int StatusId { get; set; }
        public EntityStatus Status { get; set; }

        public Guid PartyId { get; set; }
        public Party Party { get; set; }

        public List<OrderDocuments> InvoiceImages{ get; set; }
    }
}
