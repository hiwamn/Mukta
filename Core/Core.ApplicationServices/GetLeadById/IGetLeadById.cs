using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetLeadById : IApplicationService
    {
        GetLeadByIdResultDto Execute(GetLeadByIdDto dto);
    }
}
