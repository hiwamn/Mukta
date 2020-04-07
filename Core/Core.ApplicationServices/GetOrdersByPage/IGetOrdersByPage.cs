using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetOrdersByPage : IApplicationService
    {
        GetOrdersByPageResultDto Execute(GetOrdersByPageDto dto);
    }
}
