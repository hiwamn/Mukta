using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class AddLeadDto
    {
        public List<StoreCategoryDto> Categories { get; set; }
        public Guid UserId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        public double StoreLat { get; set; }
        public double StoreLon { get; set; }
        public List<Guid> StoreImages { get; set; }
        public double StoreNumber { get; set; }
        public string StoreEmail { get; set; }

        public int TypeId { get; set; }
        public string OtherCompanyRepresented { get; set; }
        public string Investment { get; set; }
        public string CreditLimit { get; set; }
        public bool? GstStatus { get; set; }


    }
}
