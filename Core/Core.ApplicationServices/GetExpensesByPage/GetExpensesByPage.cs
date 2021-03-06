﻿using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetExpensesByPage : IGetExpensesByPage
    {

        private readonly IUnitOfWork unit;

        public GetExpensesByPage(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetExpensesByPageResultDto Execute(GetExpensesByPageDto dto)
        {
            GetExpensesByPageResultDto result = new GetExpensesByPageResultDto { Status = true,Page = new PageDto { PageNo = dto.PageNo} };
            List<ExpenseDto> lst = unit.Expense.GetExpensesByPage(dto);
            result.Object = lst;
            result.Page.Total = unit.Expense.GetExpensesByPageCount(dto);
            result.Page.CurrentCount = lst.Count;
            return result;
        }
    }

    
}
