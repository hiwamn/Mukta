using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IEditParty : IApplicationService
    {
        ApiResult Execute(EditPartyDto dto);
    }
}
