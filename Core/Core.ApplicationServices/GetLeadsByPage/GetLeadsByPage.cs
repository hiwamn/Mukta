using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetLeadsByPage : IGetLeadsByPage
    {

        private readonly IUnitOfWork unit;

        public GetLeadsByPage(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetLeadsByPageResultDto Execute(GetLeadsByPageDto dto)
        {
            GetLeadsByPageResultDto result = new GetLeadsByPageResultDto { Status = true,Page = new PageDto { PageNo = dto.PageNo} };
            List<LeadDto> lst = unit.Lead.GetLeadsByPage(dto);
            result.Object = lst;
            result.Page.Total = unit.Lead.GetLeadsByPageCount(dto);
            result.Page.CurrentCount = lst.Count;
            return result;
        }
    }

    
}
