using Core.ApplicationServices;
using Core.Entities.Dto;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Tools.General;

namespace Infrastructure.EndPoint.Controllers
{

    public class UnAuthorizedController : SimpleController
    {

        public UnAuthorizedController()
        {
        }
    }
}
