using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IEditOrder : IApplicationService
    {
        ApiResult Execute(EditOrderDto dto);
    }
}
