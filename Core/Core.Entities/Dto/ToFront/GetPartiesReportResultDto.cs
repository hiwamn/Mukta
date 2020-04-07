using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetPartiesReportDto 
    {

    }
    public class GetPartiesReportResultDto : BaseApiResult
    {
        public List<PartyDto> Object { get; set; }
    }

    
 
}
