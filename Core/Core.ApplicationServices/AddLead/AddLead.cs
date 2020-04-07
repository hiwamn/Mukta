using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class AddLead : IAddLead
    {

        private readonly IUnitOfWork unit;

        public AddLead(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(AddLeadDto dto)
        {
            ApiResult result = new ApiResult { Status = true,Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();
            Lead le = new Lead
            {
                UserId = dto.UserId,
                StatusId = Enums.EntityStatus.Deactive.ToInt(),
                StoreLon = dto.StoreLon,
                StoreLat = dto.StoreLat,
                CreatedAt = now,
                StoreAddress = dto.StoreAddress,
                StoreEmail = dto.StoreEmail,
                StoreName = dto.StoreName,
                StoreNumber = dto.StoreNumber,
                UpdatedAt = now,                
                CreditLimit = dto.CreditLimit,
                GstStatus = dto.GstStatus,
                Investment = dto.Investment,
                OtherCompanyRepresented = dto.OtherCompanyRepresented,
                TypeId = dto.TypeId,
                
            };
            unit.Lead.Add(le);
            unit.Complete();
            List<LeadStoreCategories> lsc = new List<LeadStoreCategories>();
            var validCat = dto.Categories.Where(p => p.Id != null).Select(p => p.Id).ToList();
            var cat = dto.Categories.Where(p => p.Id == null).Select(p => new StoreCategory { CreatedAt = now, Name = p.Name }).ToList();
            unit.StoreCategory.AddRange(cat);
            unit.Complete();
            validCat.ForEach(p => lsc.Add(new LeadStoreCategories { CreatedAt = now, LeadId = le.Id, StoreCategoryId = p.Value }));
            cat.ForEach(p => lsc.Add(new LeadStoreCategories { CreatedAt = now, LeadId = le.Id, StoreCategoryId = p.Id }));
            unit.LeadStoreCategories.AddRange(lsc);
            unit.Complete();
            var StoreImages = dto.StoreImages.Select(p => new LeadDocuments { CreatedAt = now, DocumentId = p, LeadId = le.Id }).ToList();
            unit.LeadDocuments.AddRange(StoreImages);
            unit.Complete();
            le.StoreCategories = lsc;
            le.StoreImages = StoreImages;
            result.Object = Agent.ToJson(le);
            return result;
        }
    }
}
