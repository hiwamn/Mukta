using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Lead : UserBaseEntity
    {
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public double StoreLat { get; set; }
        public double StoreLon { get; set; }
        public List<LeadDocuments> StoreImages{ get; set; }
        public double StoreNumber { get; set; }
        public string StoreEmail { get; set; }
        public long UpdatedAt{ get; set; }

        public int StatusId { get; set; }
        public EntityStatus Status { get; set; }

        public List<LeadStoreCategories> StoreCategories { get; set; }
        public int? TypeId { get; set; }
        public PartyType Type { get; set; }
        public string OtherCompanyRepresented { get; set; }
        public string Investment { get; set; }
        public string CreditLimit { get; set; }
        public bool? GstStatus { get; set; }


    }
}
