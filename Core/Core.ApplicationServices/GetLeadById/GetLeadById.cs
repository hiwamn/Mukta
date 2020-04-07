using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetLeadById : IGetLeadById
    {

        private readonly IUnitOfWork unit;

        public GetLeadById(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetLeadByIdResultDto Execute(GetLeadByIdDto dto)
        {
            GetLeadByIdResultDto result = new GetLeadByIdResultDto { Status = true};
            LeadDto lst = unit.Lead.GetLeadById(dto);
            result.Object = lst;
            return result;
        }
    }

    
}
