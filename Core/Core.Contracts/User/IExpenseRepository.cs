using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        List<ExpenseDto> GetExpensesByPage(GetExpensesByPageDto dto);
        int GetExpensesByPageCount(GetExpensesByPageDto dto);
        AverageExpense GetAverageExpenseReport(GetAverageExpenseReportDto dto);
        ExpenseDto GetExpenseById(GetExpenseByIdDto dto);
        List<FixedDto> Search(SearchDto dto);
        int GetNewCount();
    }
}
