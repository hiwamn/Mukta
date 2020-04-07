using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetPartyByIdDto : BaseByIdDto
    {

    }
    public class GetPartyByIdResultDto : BaseApiResult
    {
        public PartyDto Object { get; set; }
    }
}
