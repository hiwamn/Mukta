
using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class OrderDto
    {
        public long CreatedAt { get; internal set; }
        public string DeliveryPeriod { get; internal set; }
        public string Description { get; internal set; }
        public string Discount { get; internal set; }
        public Guid Id { get; internal set; }
        public bool Insurance { get; internal set; }
        public List<string> InvoiceImages { get; internal set; }
        public string ItemCode { get; internal set; }
        public string NetPrice { get; internal set; }
        public bool PaymentTerms { get; internal set; }
        public long PurchaseOrderValidityDate { get; internal set; }
        public string Quantity { get; internal set; }
        public string RatePerUnit { get; internal set; }
        public string SaleTax { get; internal set; }
        public int SlNo { get; internal set; }
        public int StatusId { get; internal set; }
        public string Days { get; internal set; }
        public PartyDto Party { get; internal set; }
        public string DayCount { get; internal set; }
        public object Name { get; internal set; }
    }


}
