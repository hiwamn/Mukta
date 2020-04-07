using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetExpenseById : IGetExpenseById
    {

        private readonly IUnitOfWork unit;

        public GetExpenseById(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetExpenseByIdResultDto Execute(GetExpenseByIdDto dto)
        {
            GetExpenseByIdResultDto result = new GetExpenseByIdResultDto { Status = true, };
            ExpenseDto lst = unit.Expense.GetExpenseById(dto);
            result.Object = lst;
            return result;
        }
    }

    
}
