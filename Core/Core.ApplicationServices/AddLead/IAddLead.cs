using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IAddLead : IApplicationService
    {
        ApiResult Execute(AddLeadDto dto);
    }
}
