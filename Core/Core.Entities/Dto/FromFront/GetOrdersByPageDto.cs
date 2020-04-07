using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetOrdersByPageDto : BaseByUserPageDto
    {
        public Guid? PartyId { get; set; }
    }
    public class GetOrdersByPageResultDto : BaseApiPageResult
    {
        public List<OrderDto> Object { get; set; }
    }
}
