using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetExpensesByPage : IApplicationService
    {
        GetExpensesByPageResultDto Execute(GetExpensesByPageDto dto);
    }
}
