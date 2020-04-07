using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetUsersByPageDto : BaseByPageDto
    {
        public int? Status { get; set; }
    }
    public class GetUsersByPageResultDto : BaseApiPageResult
    {
        public List<UserDto> Object { get; set; }
    }
}
