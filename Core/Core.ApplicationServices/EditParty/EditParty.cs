using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class EditParty : IEditParty
    {

        private readonly IUnitOfWork unit;

        public EditParty(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(EditPartyDto dto)
        {
            var now = DateTime.Now.ToUnix();
            ApiResult result = new ApiResult { Status = true, Message = Messages.Success, };

            Party par = unit.Party.Get(dto.Id);

            par.ContractNumber = dto.ContractNumber;
            par.CreditLimit = dto.CreditLimit;
            par.GstStatus = dto.GstStatus;
            par.Investment = dto.Investment;
            par.OtherCompanyRepresented = dto.OtherCompanyRepresented;
            par.StoreAddress = dto.StoreAddress;
            par.StoreEmail = dto.StoreEmail;
            par.StoreLat = dto.StoreLat;
            par.StoreLon = dto.StoreLon;
            par.StoreName = dto.StoreName;
            par.StoreNumber = dto.StoreNumber;
            par.TotalOutput = dto.TotalOutput;
            par.TypeId = dto.TypeId;
            par.UpdatedAt = now;            

            unit.Complete();
            EditCategories(dto);
            EditImages(dto);
            result.Object = par;
            return result;
        }

        private void EditImages(EditPartyDto dto)
        {
            var now = DateTime.Now.ToUnix();
            //StoreImages = dto.StoreImages.Select(p=>new PartyDocuments {CreatedAt=now,DocumentId=p}).ToList()
        }

        private void EditCategories(EditPartyDto dto)
        {
            var now = DateTime.Now.ToUnix();
            List<StoreCategory> cat = new List<StoreCategory>();
            if (dto.Categories != null)
            {
                cat = dto.Categories.Where(p => p.Id == null).Select(p => new StoreCategory { CreatedAt = now, Name = p.Name }).ToList();
                unit.StoreCategory.AddRange(cat);
                unit.Complete();
            }
            //unit.PartyDocuments.AddRange(dto.StoreImages.Select(p => new PartyDocuments { CreatedAt = now, DocumentId = p ,PartyId = par.Id}).ToList());
            //unit.Complete();
            //if (dto.Categories != null)
            //{
            //    List<PartyStoreCategories> psc = new List<PartyStoreCategories>();
            //    var validCat = dto.Categories.Where(p => p.Id != null).Select(p => p.Id).ToList();
            //    validCat.ForEach(p => psc.Add(new PartyStoreCategories { CreatedAt = now, PartyId = par.Id, StoreCategoryId = p }));
            //    cat.ForEach(p => psc.Add(new PartyStoreCategories { CreatedAt = now, PartyId = par.Id, StoreCategoryId = p.Id }));
            //    unit.PartyStoreCategories.AddRange(psc);
            //    unit.Complete();
            //}
        }
    }
}
