using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetOrderById : IGetOrderById
    {

        private readonly IUnitOfWork unit;

        public GetOrderById(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetOrderByIdResultDto Execute(GetOrderByIdDto dto)
        {
            GetOrderByIdResultDto result = new GetOrderByIdResultDto { Status = true };
            OrderDto lst = unit.Order.GetOrderById(dto);
            result.Object = lst;
            return result;
        }
    }

    
}
