
using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class PartyDto
    {
        public UserShoerDto User { get; set; }
        public string ContractNumber { get; internal set; }
        public long CreatedAt { get; internal set; }
        public string CreditLimit { get; internal set; }
        public bool? GstStatus { get; internal set; }
        public Guid Id { get; internal set; }
        public string Investment { get; internal set; }
        public string OtherCompanyRepresented { get; internal set; }
        public int StatusId { get; internal set; }
        public string StoreAddress { get; internal set; }
        public List<StoreCategoryDto> StoreCategories { get; internal set; }
        public string StoreEmail { get; internal set; }
        public List<string> StoreImages { get; internal set; }
        public double StoreLat { get; internal set; }
        public double StoreLon { get; internal set; }
        public string StoreName { get; internal set; }
        public string StoreNumber { get; internal set; }
        public string TotalOutput { get; internal set; }
        public int TypeId { get; internal set; }
        public long UpdatedAt { get; internal set; }
    }
    public class PartyShortDto
    {
        public Guid Id { get; internal set; }
        public List<string> StoreImages { get; internal set; }
        public double StoreLat { get; internal set; }
        public double StoreLon { get; internal set; }
        public string StoreName { get; internal set; }
    }


}
