using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IAddOrder : IApplicationService
    {
        ApiResult Execute(AddOrderDto dto);
    }
}
