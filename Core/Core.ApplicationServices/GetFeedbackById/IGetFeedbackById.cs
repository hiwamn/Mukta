using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetFeedbackById : IApplicationService
    {
        GetFeedbackByIdResultDto Execute(GetFeedbackByIdDto dto);
    }
}
