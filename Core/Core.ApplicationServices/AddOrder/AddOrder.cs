using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class AddOrder : IAddOrder
    {

        private readonly IUnitOfWork unit;

        public AddOrder(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(AddOrderDto dto)
        {
            ApiResult result = new ApiResult { Status = true, Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();

            Order ord = new Order
            {
                PartyId = dto.PartyId,
                StatusId = Enums.EntityStatus.Deactive.ToInt(),
                CreatedAt = now,
                InvoiceImages = dto.InvoiceImages?.Select(p => new OrderDocuments { CreatedAt = now, DocumentId = p }).ToList(),
                DeliveryPeriod = dto.DeliveryPeriod,
                Description = dto.Description,
                Discount = dto.Discount,
                Insurance = dto.Insurance,
                ItemCode = dto.ItemCode,
                NetPrice = dto.NetPrice,
                PaymentTerms = dto.PaymentTerms,
                PurchaseOrderValidityDate = dto.PurchaseOrderValidityDate,
                Quantity = dto.Quantity,
                RatePerUnit = dto.RatePerUnit,
                SaleTax = dto.SaleTax,
                SlNo = unit.Order.GetMaxSlNo(),
                Days = dto.Days,
                DayCount = dto.DayCount,
                Name = dto.Name
            };
            unit.Order.Add(ord);
            unit.Complete();
            result.Object = Agent.ToJson(ord);
            return result;
        }
    }
}
