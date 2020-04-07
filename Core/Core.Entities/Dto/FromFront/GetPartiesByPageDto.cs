using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetPartiesByPageDto : BaseByUserPageDto
    {
        public string Keyword { get; set; }
    }
    public class GetPartiesByPageResultDto : BaseApiPageResult
    {
        public List<PartyDto> Object { get; set; }
    }
}
