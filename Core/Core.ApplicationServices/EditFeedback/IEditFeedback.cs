using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IEditFeedback : IApplicationService
    {
        ApiResult Execute(EditFeedbackDto dto);
    }
}
