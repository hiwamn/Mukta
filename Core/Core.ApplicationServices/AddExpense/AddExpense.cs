using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class AddExpense : IAddExpense
    {

        private readonly IUnitOfWork unit;

        public AddExpense(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(AddExpenseDto dto)
        {
            ApiResult result = new ApiResult { Status = true,Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();
            Expense ex = new Expense
            {
                UserId = dto.UserId,
                StatusId = Enums.EntityStatus.Deactive.ToInt(),
                Lon = dto.Lon,
                Lat = dto.Lat,
                CreatedAt = now,
                Amount = dto.Amount,
                Name = dto.Name
            };
            unit.Expense.Add(ex);
            unit.Complete();
            
            List<StoreCategory> cat = new List<StoreCategory>();
            if (dto.Categories != null)
            {
                
                cat = dto.Categories.Where(p => p.Id == null).Select(p => new StoreCategory { CreatedAt = now, Name = p.Name }).ToList();
                unit.StoreCategory.AddRange(cat);
                unit.Complete();
            }
            List<ExpenseCategory> ec = new List<ExpenseCategory>();
            if (dto.Categories != null)
            {
                var validCat = dto.Categories.Where(p => p.Id != null).Select(p => p.Id).ToList();
                validCat.ForEach(p => ec.Add(new ExpenseCategory { CreatedAt = now, ExpenseId = ex.Id, StoreCategoryId = p.Value }));
                cat.ForEach(p => ec.Add(new ExpenseCategory { CreatedAt = now, ExpenseId = ex.Id, StoreCategoryId = p.Id }));
                unit.ExpenseCategory.AddRange(ec);
                unit.Complete();
            }
            ex.Categories = ec;
            result.Object = Agent.ToJson(ex);
            return result;
        }
    }
}
