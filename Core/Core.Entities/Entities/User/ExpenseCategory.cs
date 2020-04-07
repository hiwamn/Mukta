using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ExpenseCategory : BaseEntity
    {
        public Guid ExpenseId { get; set; }
        public Expense Expense { get; set; }
        public Guid StoreCategoryId { get; set; }
        public StoreCategory StoreCategory { get; set; }
    }
}
