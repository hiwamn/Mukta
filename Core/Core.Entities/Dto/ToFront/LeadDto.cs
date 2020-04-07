
using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class LeadDto
    {
        public UserShoerDto User { get; set; }
        public long CreatedAt { get; internal set; }
        public Guid Id { get; internal set; }
        public int StatusId { get; internal set; }
        public string StoreAddress { get; internal set; }
        public string StoreEmail { get; internal set; }
        public double StoreLat { get; internal set; }
        public double StoreLon { get; internal set; }
        public string StoreName { get; internal set; }
        public double StoreNumber { get; internal set; }
        public long UpdatedAt { get; internal set; }
        public List<string> StoreImages { get; internal set; }
        public int? TypeId { get; set; }
        public string OtherCompanyRepresented { get; set; }
        public string Investment { get; set; }
        public string CreditLimit { get; set; }
        public bool? GstStatus { get; set; }
        public List<StoreCategoryDto> StoreCategories { get; internal set; }
    }


}
