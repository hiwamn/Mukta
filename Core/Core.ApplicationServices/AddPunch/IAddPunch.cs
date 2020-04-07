using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IAddPunch : IApplicationService
    {
        ApiResult Execute(AddPunchDto dto);
    }
}
