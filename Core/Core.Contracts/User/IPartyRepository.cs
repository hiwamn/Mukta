using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IPartyRepository : IRepository<Party>
    {
        List<PartyDto> GetPartiesByPage(GetPartiesByPageDto dto);
        int GetPartiesByPageCount(GetPartiesByPageDto dto);
        List<PartyShortDto> GetPartiesLocation(GetPartiesLocationDto dto);
        PartyDto GetPartyById(GetPartyByIdDto dto);
        List<FixedDto> Search(SearchDto dto);
        int GetNewCount();
    }
}
