using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface ILeadRepository : IRepository<Lead>
    {
        List<LeadDto> GetLeadsByPage(GetLeadsByPageDto dto);
        int GetLeadsByPageCount(GetLeadsByPageDto dto);
        LeadDto GetLeadById(GetLeadByIdDto dto);
        List<FixedDto> Search(SearchDto dto);
        int GetNewCount();
    }
}
