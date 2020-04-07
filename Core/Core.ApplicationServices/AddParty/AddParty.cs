using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class AddParty : IAddParty
    {

        private readonly IUnitOfWork unit;

        public AddParty(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(AddPartyDto dto)
        {
            ApiResult result = new ApiResult { Status = true,Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();

            

            Party par = new Party
            {
                UserId = dto.UserId,
                StatusId = Enums.EntityStatus.Deactive.ToInt(),
                CreatedAt = now,
                ContractNumber = dto.ContractNumber,
                CreditLimit = dto.CreditLimit,
                GstStatus = dto.GstStatus,
                Investment = dto.Investment,
                OtherCompanyRepresented = dto.OtherCompanyRepresented,
                StoreAddress = dto.StoreAddress,
                StoreEmail = dto.StoreEmail,
                StoreLat = dto.StoreLat,
                StoreLon = dto.StoreLon,
                StoreName = dto.StoreName,
                StoreNumber = dto.StoreNumber,
                TotalOutput = dto.TotalOutput,
                TypeId = dto.TypeId,
                UpdatedAt = now,      
                //StoreImages = dto.StoreImages.Select(p=>new PartyDocuments {CreatedAt=now,DocumentId=p}).ToList()
            };
            unit.Party.Add(par);
            unit.Complete();
            
            List<StoreCategory> cat = new List<StoreCategory>();
            if (dto.Categories != null)
            {
                cat = dto.Categories.Where(p => p.Id == null).Select(p => new StoreCategory { CreatedAt = now, Name = p.Name }).ToList();
                unit.StoreCategory.AddRange(cat);
                unit.Complete();
            }
            unit.PartyDocuments.AddRange(dto.StoreImages.Select(p => new PartyDocuments { CreatedAt = now, DocumentId = p ,PartyId = par.Id}).ToList());
            unit.Complete();
            List<PartyStoreCategories> psc = new List<PartyStoreCategories>();
            if (dto.Categories != null)
            {                
                var validCat = dto.Categories.Where(p => p.Id != null).Select(p => p.Id).ToList();
                validCat.ForEach(p => psc.Add(new PartyStoreCategories { CreatedAt = now, PartyId = par.Id, StoreCategoryId = p.Value }));
                cat.ForEach(p => psc.Add(new PartyStoreCategories { CreatedAt = now, PartyId = par.Id, StoreCategoryId = p.Id }));
                unit.PartyStoreCategories.AddRange(psc);
                unit.Complete();
            }
            par.StoreCategories = psc;
            result.Object = Agent.ToJson(par);
            return result;
        }
    }
}
