using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetLeadsByPage : IApplicationService
    {
        GetLeadsByPageResultDto Execute(GetLeadsByPageDto dto);
    }
}
