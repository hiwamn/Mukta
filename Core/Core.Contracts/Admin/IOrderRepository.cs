using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<OrderDto> GetOrdersByPage(GetOrdersByPageDto dto);
        int GetOrdersByPageCount(GetOrdersByPageDto dto);
        OrderDto GetOrderById(GetOrderByIdDto dto);
        int GetMaxSlNo();
        List<FixedDto> Search(SearchDto dto);
        int GetNewCount();
    }
}
