using Core.ApplicationServices;
using Core.Entities;
using Core.Entities.Dto;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.EndPoint.Controllers
{
    
    public class StoreCategoryController : SimpleController
    {
        private readonly IGetStoreCategories getStoreCategories;

        public StoreCategoryController(IGetStoreCategories getStoreCategories)
        {
            this.getStoreCategories = getStoreCategories;
        }

        [HttpGet]
        
        public ActionResult<GetStoreCategoriesResultDto> GetStoreCategories()
        {
            return getStoreCategories.Execute();
        }
        

    }
}
