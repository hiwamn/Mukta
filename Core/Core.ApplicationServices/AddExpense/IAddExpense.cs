using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IAddExpense : IApplicationService
    {
        ApiResult Execute(AddExpenseDto dto);
    }
}
