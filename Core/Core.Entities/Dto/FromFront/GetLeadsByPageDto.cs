using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetLeadsByPageDto : BaseByUserPageDto
    {

    }
    public class GetLeadsByPageResultDto : BaseApiPageResult
    {
        public List<LeadDto> Object { get; set; }
    }
}
