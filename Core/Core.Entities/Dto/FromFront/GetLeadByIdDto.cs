using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetLeadByIdDto : BaseByIdDto
    {

    }
    public class GetLeadByIdResultDto : BaseApiResult
    {
        public LeadDto Object { get; set; }
    }
}
