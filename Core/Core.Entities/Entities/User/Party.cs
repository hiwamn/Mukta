using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Party : UserBaseEntity
    {
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public double StoreLat { get; set; }
        public double StoreLon { get; set; }
        public List<PartyDocuments> StoreImages { get; set; }
        public string StoreNumber { get; set; }
        public string StoreEmail { get; set; }
        public long UpdatedAt { get; set; }

        public int StatusId { get; set; }
        public EntityStatus Status { get; set; }

        public List<PartyStoreCategories> StoreCategories{ get; set; }
        public List<Order> Order { get; set; }
        public List<Feedback> Feedback { get; set; }
        public int TypeId { get; set; }
        public PartyType Type { get; set; }
        public string TotalOutput { get; set; }
        public string OtherCompanyRepresented { get; set; }
        public string ContractNumber { get; set; }
        public string Investment { get; set; }
        public string CreditLimit { get; set; }
        public bool? GstStatus{ get; set; }



    }
}
