using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetPartiesLocationDto : BaseApiResult
    {

    }
    public class GetPartiesLocationResultDto : BaseApiResult
    {
        public List<PartyShortDto> Object { get; set; }
    }

}
