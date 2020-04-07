using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IAddFeedback : IApplicationService
    {
        ApiResult Execute(AddFeedbackDto dto);
    }
}
