using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class LeadStoreCategories : BaseEntity
    {
        public Guid  LeadId{ get; set; }
        public Lead  Lead{ get; set; }
        public Guid  StoreCategoryId{ get; set; }
        public StoreCategory StoreCategory { get; set; }
    }
}
