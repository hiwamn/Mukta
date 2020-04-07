using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetPartiesLocation : IGetPartiesLocation
    {

        private readonly IUnitOfWork unit;

        public GetPartiesLocation(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetPartiesLocationResultDto Execute(GetPartiesLocationDto dto)
        {
            GetPartiesLocationResultDto result = new GetPartiesLocationResultDto { Status = true,};
            List<PartyShortDto> lst = unit.Party.GetPartiesLocation(dto);
            result.Object = lst;
            return result;
        }
    }

    
}
