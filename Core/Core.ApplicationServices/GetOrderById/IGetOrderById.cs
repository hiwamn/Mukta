using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetOrderById : IApplicationService
    {
        GetOrderByIdResultDto Execute(GetOrderByIdDto dto);
    }
}
