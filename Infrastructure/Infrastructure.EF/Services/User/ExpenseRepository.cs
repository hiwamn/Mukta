using Core.ApplicationServices;
using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using Core.Entities.Functions;
using Core.Entities.GlobalSettings;
using Domain.Contract;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.EF.Services
{
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        private readonly IContext ctx;

        public ExpenseRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public AverageExpense GetAverageExpenseReport(GetAverageExpenseReportDto dto)
        {
            var years = DateTime.Now.SubDays(-3 * 356).ToUnix();
            var expense = ctx.Expenses.Where(p => p.CreatedAt > years).ToList();

            return new AverageExpense
            {
                LastThreeYearYears = expense.GroupBy(p => p.CreatedAt.ToDate().Year).Select(t => new ExpensePerYear { Year = t.Key.ToString(), Amount = t.ToList().Sum(r => r.Amount) }).ToList(),
                LastThreeYearMonths = expense.GroupBy(p => new { Year = p.CreatedAt.ToDate().Year, Month = p.CreatedAt.ToDate().Month }).Select(t => new ExpensePerMonth { MonthName = $"{t.Key.Year.ToString()}/{t.Key.Month.ToString()}", Amount = t.ToList().Sum(r => r.Amount) }).ToList(),
                LastThreeYearDays = expense.GroupBy(p => new { Year = p.CreatedAt.ToDate().Year, Month = p.CreatedAt.ToDate().Month, Day = p.CreatedAt.ToDate().Day }).Select(t => new ExpensePerDay { DayName = $"{t.Key.Year.ToString()}/{t.Key.Month.ToString()}/{t.Key.Day.ToString()}", Amount = t.ToList().Sum(r => r.Amount) }).ToList(),
                TotalCount = expense.Sum(p => p.Amount)
            };
        }

        public ExpenseDto GetExpenseById(GetExpenseByIdDto dto)
        {
            return ctx.Expenses.
                 Where(p => p.Id == dto.Id.ToGuid()).
                 Include(p => p.Categories).ThenInclude(p => p.StoreCategory).
                 Select(p => DtoBuilder.CreateExpenseDto(p)).
                 FirstOrDefault();
        }

        public List<ExpenseDto> GetExpensesByPage(GetExpensesByPageDto dto)
        {
            return ctx.Expenses.
                 Skip((dto.PageNo - 1) * AdminSettings.Block).
                 Take(AdminSettings.Block).
                 Where(p => dto.UserId == null || p.UserId == dto.UserId).
                 Include(p => p.Categories).ThenInclude(p => p.StoreCategory).
                 Select(p => DtoBuilder.CreateExpenseDto(p)).
                 ToList();
        }

        public int GetExpensesByPageCount(GetExpensesByPageDto dto)
        {
            return ctx.Expenses.
                Where(p => dto.UserId == null || p.UserId == dto.UserId).
                Count();
        }

        public int GetNewCount()
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            return ctx.Expenses.
                Where(p => p.CreatedAt > nowStart).Count();
        }

        public List<FixedDto> Search(SearchDto dto)
        {
            return ctx.Expenses.
                Where(p => dto.UserId == null || dto.UserId == p.UserId).                
                Select(p=>new FixedDto {Id = p.Id,Title=p.CreatedAt.ToDateLongString(),Description = "",Name = p.Name }).ToList();
        }
    }
}
