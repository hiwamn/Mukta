using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class EditExpense : IEditExpense
    {

        private readonly IUnitOfWork unit;

        public EditExpense(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(EditExpenseDto dto)
        {            
            ApiResult result = new ApiResult { Status = true, Message = Messages.Success, };
            var ex = unit.Expense.Get(dto.Id);
            ex.Lon = dto.Lon;
            ex.Lat = dto.Lat;
            ex.Amount = dto.Amount;
            ex.Name= dto.Name;
            unit.Complete();
            EditCategories(dto);
            result.Object = ex;
            return result;
        }

        private void EditCategories(EditExpenseDto dto)
        {
            //var now = DateTime.Now.ToUnix();
            //List<StoreCategory> cat = new List<StoreCategory>();
        
            //if (dto.Categories != null)
            //{
            //    cat = dto.Categories.Where(p => p.Id == null).Select(p => new StoreCategory { CreatedAt = now, Name = p.Name }).ToList();
            //    unit.StoreCategory.AddRange(cat);
            //    unit.Complete();
            //}
            //List<ExpenseCategory> ec = new List<ExpenseCategory>();
            //if (dto.Categories != null)
            //{
            //    var validCat = dto.Categories.Where(p => p.Id != null).Select(p => p.Id).ToList();
            //    validCat.ForEach(p => ec.Add(new ExpenseCategory { CreatedAt = now, ExpenseId = ex.Id, StoreCategoryId = p }));
            //    cat.ForEach(p => ec.Add(new ExpenseCategory { CreatedAt = now, ExpenseId = ex.Id, StoreCategoryId = p.Id }));
            //    unit.ExpenseCategory.AddRange(ec);
            //    unit.Complete();
            //}
        }
    }
}
