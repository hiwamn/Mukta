using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class StoreCategory : BaseEntity
    {
        public string Name { get; set; }
        public List<ExpenseCategory> ExpenseCategory { get; set; }
        public List<PartyStoreCategories> PartyStoreCategories { get; set; }
        public List<LeadStoreCategories> LeadStoreCategories { get; set; }
    }
}
