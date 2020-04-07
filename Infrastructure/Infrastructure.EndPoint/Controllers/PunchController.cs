using Core.ApplicationServices;
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
    public class PunchController : SimpleController
    {
        private readonly IAddPunch addPunch;

        public PunchController(
            IAddPunch addPunch)
        {
            this.addPunch = addPunch;
        }
        [HttpPost]
        public ActionResult<ApiResult> AddPunch([FromBody]AddPunchDto dto)
        {
            return addPunch.Execute(dto);
        }
       



    }
}
