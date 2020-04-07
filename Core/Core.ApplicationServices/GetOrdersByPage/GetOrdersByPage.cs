using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetOrdersByPage : IGetOrdersByPage
    {

        private readonly IUnitOfWork unit;

        public GetOrdersByPage(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetOrdersByPageResultDto Execute(GetOrdersByPageDto dto)
        {
            GetOrdersByPageResultDto result = new GetOrdersByPageResultDto { Status = true,Page = new PageDto { PageNo = dto.PageNo} };
            List<OrderDto> lst = unit.Order.GetOrdersByPage(dto);
            result.Object = lst;
            result.Page.Total = unit.Order.GetOrdersByPageCount(dto);
            result.Page.CurrentCount = lst.Count;
            return result;
        }
    }

    
}
