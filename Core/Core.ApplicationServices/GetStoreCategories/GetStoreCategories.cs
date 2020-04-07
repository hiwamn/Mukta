using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetStoreCategories : IGetStoreCategories
    {
        private readonly IUnitOfWork unit;

        public GetStoreCategories(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public GetStoreCategoriesResultDto Execute()
        {
            return new GetStoreCategoriesResultDto
            {
                Object = unit.StoreCategory.GetAll().Select(p=>new StoreCategoryDto{Id=p.Id,Name = p.Name }).ToList(),
                Status = true
            };
        }
    }

    
}
