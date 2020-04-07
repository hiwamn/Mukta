using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class AddPartyDto
    {
        public Guid UserId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public double StoreLat { get; set; }
        public double StoreLon { get; set; }
        public List<Guid> StoreImages { get; set; }
        public string StoreNumber { get; set; }
        public string StoreEmail { get; set; }
        public List<StoreCategoryDto> Categories { get; set; }
        public int TypeId { get; set; }
        public string TotalOutput { get; set; }
        public string OtherCompanyRepresented { get; set; }
        public string ContractNumber { get; set; }
        public string Investment { get; set; }
        public string CreditLimit { get; set; }
        public bool? GstStatus { get; set; }
    }
}
