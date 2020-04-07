using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetFeedbacksByPage : IApplicationService
    {
        GetFeedbacksByPageResultDto Execute(GetFeedbacksByPageDto dto);
    }
}
