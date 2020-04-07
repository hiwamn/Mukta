using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IAddParty : IApplicationService
    {
        ApiResult Execute(AddPartyDto dto);
    }
}
