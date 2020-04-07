using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class EditLead : IEditLead
    {

        private readonly IUnitOfWork unit;

        public EditLead(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(EditLeadDto dto)
        {
            var now = DateTime.Now.ToUnix();
            ApiResult result = new ApiResult { Status = true, Message = Messages.Success, };
            Lead le = unit.Lead.Get(dto.Id);

            le.StoreLon = dto.StoreLon;
            le.StoreLat = dto.StoreLat;
            le.StoreAddress = dto.StoreAddress;
            le.StoreEmail = dto.StoreEmail;
            le.StoreName = dto.StoreName;
            le.StoreNumber = dto.StoreNumber;
            le.UpdatedAt = now;            
            le.CreditLimit = dto.CreditLimit;
            le.GstStatus = dto.GstStatus;
            le.Investment = dto.Investment;
            le.OtherCompanyRepresented = dto.OtherCompanyRepresented;
            le.TypeId = dto.TypeId;


            unit.Complete();

            EditCategories(dto);
            EditImages(dto);
            result.Object = le;
            return result;
        }

        private void EditImages(EditLeadDto dto)
        {
            //var now = DateTime.Now.ToUnix();
            //List<LeadDocuments> images = unit.LeadDocuments.GetByLeadId(dto.Id);
            ////le.StoreImages = dto.StoreImages.Select(p => new LeadDocuments { CreatedAt = now, DocumentId = p }).ToList();
        }

        private void EditCategories(EditLeadDto dto)
        {
            var now = DateTime.Now.ToUnix();
            var validCat = dto.Categories.Where(p => p.Id != null).Select(p => p.Id).ToList();
            var cat = dto.Categories.Where(p => p.Id == null).Select(p => new StoreCategory { CreatedAt = now, Name = p.Name }).ToList();
            unit.StoreCategory.AddRange(cat);
            unit.Complete();
            //List<LeadStoreCategories> lsc = new List<LeadStoreCategories>();
            //validCat.ForEach(p => lsc.Add(new LeadStoreCategories { CreatedAt = now, LeadId = le.Id, StoreCategoryId = p }));
            //cat.ForEach(p => lsc.Add(new LeadStoreCategories { CreatedAt = now, LeadId = le.Id, StoreCategoryId = p.Id }));
            //unit.LeadStoreCategories.AddRange(lsc);
            //unit.Complete();
        }
    }
}
