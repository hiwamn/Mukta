using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IEditExpense : IApplicationService
    {
        ApiResult Execute(EditExpenseDto dto);
    }
}
