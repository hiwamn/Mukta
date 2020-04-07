using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class PartyStoreCategories : BaseEntity
    {
        public Guid  PartyId{ get; set; }
        public Party  Party{ get; set; }
        public Guid  StoreCategoryId{ get; set; }
        public StoreCategory StoreCategory { get; set; }
    }
}
