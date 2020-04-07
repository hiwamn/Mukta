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

    public class CityController : SimpleController// AuthorizedController
    {
        private readonly IGetCities getCities;
      

        public CityController(
            IGetCities getCities)
        {
            this.getCities = getCities;
        }

        [HttpGet]
        public ActionResult<GetCitiesResultDto> GetCities([FromQuery]GetCitiesDto dto)
        {
            return getCities.Execute(dto);
        }
       
    }
}
