using Core.Entities.Dto;

namespace Core.ApplicationServices
{
    public interface IGetExpenseById : IApplicationService
    {
        GetExpenseByIdResultDto Execute(GetExpenseByIdDto dto);
    }
}
