using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetPartyById : IGetPartyById
    {

        private readonly IUnitOfWork unit;

        public GetPartyById(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetPartyByIdResultDto Execute(GetPartyByIdDto dto)
        {
            GetPartyByIdResultDto result = new GetPartyByIdResultDto { Status = true };
            PartyDto lst = unit.Party.GetPartyById(dto);
            result.Object = lst;
            return result;
        }
    }

    
}
