using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IEditLead : IApplicationService
    {
        ApiResult Execute(EditLeadDto dto);
    }
}
