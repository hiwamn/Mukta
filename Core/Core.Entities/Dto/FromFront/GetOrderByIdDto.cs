using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetOrderByIdDto : BaseByIdDto
    {

    }
    public class GetOrderByIdResultDto : BaseApiResult
    {
        public OrderDto Object { get; set; }
    }
}
