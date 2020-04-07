using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetPartyById : IApplicationService
    {
        GetPartyByIdResultDto Execute(GetPartyByIdDto dto);
    }
}
