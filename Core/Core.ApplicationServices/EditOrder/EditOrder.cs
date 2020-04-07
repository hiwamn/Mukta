using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class EditOrder : IEditOrder
    {

        private readonly IUnitOfWork unit;

        public EditOrder(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(EditOrderDto dto)
        {
            ApiResult result = new ApiResult { Status = true, Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();

            Order ord = unit.Order.Get(dto.Id);

            //ord.InvoiceImages = dto.InvoiceImages.Select(p => new OrderDocuments { CreatedAt = now, DocumentId = p }).ToList();
            ord.DeliveryPeriod = dto.DeliveryPeriod;
            ord.Description = dto.Description;
            ord.Discount = dto.Discount;
            ord.Insurance = dto.Insurance;
            ord.ItemCode = dto.ItemCode;
            ord.NetPrice = dto.NetPrice;
            ord.PaymentTerms = dto.PaymentTerms;
            ord.PurchaseOrderValidityDate = dto.PurchaseOrderValidityDate;
            ord.Quantity = dto.Quantity;
            ord.RatePerUnit = dto.RatePerUnit;
            ord.SaleTax = dto.SaleTax;
            ord.Days= dto.Days;
            ord.DayCount= dto.DayCount;
            ord.Name = dto.Name;
            unit.Complete();
            result.Object = ord;
            return result;
        }
    }
}
