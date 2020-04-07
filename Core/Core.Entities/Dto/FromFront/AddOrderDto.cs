using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class AddOrderDto
    {
        public string Name { get; set; }
        public Guid PartyId { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string RatePerUnit { get; set; }
        public string Discount { get; set; }
        public string NetPrice { get; set; }
        public string SaleTax { get; set; }
        public string DeliveryPeriod { get; set; }
        public bool PaymentTerms { get; set; }
        public bool Insurance { get; set; }
        public long PurchaseOrderValidityDate { get; set; }
        public List<Guid> InvoiceImages { get; set; }
        public string Days { get; set; }
        public string DayCount { get; set; }
    }
}
