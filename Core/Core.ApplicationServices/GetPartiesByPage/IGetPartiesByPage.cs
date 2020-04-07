using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetPartiesByPage : IApplicationService
    {
        GetPartiesByPageResultDto Execute(GetPartiesByPageDto dto);
    }
}
