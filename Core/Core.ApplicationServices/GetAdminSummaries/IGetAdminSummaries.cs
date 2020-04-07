using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetAdminSummaries : IApplicationService
    {
        GetAdminSummariesResultDto Execute(GetAdminSummariesDto dto);
    }
}
