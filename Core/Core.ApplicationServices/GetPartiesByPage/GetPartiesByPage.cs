using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetPartiesByPage : IGetPartiesByPage
    {

        private readonly IUnitOfWork unit;

        public GetPartiesByPage(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetPartiesByPageResultDto Execute(GetPartiesByPageDto dto)
        {
            GetPartiesByPageResultDto result = new GetPartiesByPageResultDto { Status = true,Page = new PageDto { PageNo = dto.PageNo} };
            List<PartyDto> lst = unit.Party.GetPartiesByPage(dto);
            result.Object = lst;
            result.Page.Total = unit.Party.GetPartiesByPageCount(dto);
            result.Page.CurrentCount = lst.Count;
            return result;
        }
    }

    
}
