using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IChangeUserCity : IApplicationService
    {
        BaseApiResult Execute(ChangeUserCityDto dto);
    }
}
