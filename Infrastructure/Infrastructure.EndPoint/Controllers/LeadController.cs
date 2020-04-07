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
    public class LeadController : SimpleController
    {
        private readonly IAddLead addLead;
        private readonly IGetLeadsByPage getLeadsByPage;
        private readonly IGetLeadById getLeadById;
        private readonly IEditLead editLead;

        public LeadController(
            IAddLead addLead,
            IGetLeadsByPage getLeadsByPage,
            IGetLeadById getLeadById,
            IEditLead editLead
            )
        {
            this.addLead = addLead;
            this.getLeadsByPage = getLeadsByPage;
            this.getLeadById = getLeadById;
            this.editLead = editLead;
        }

        [HttpPost]
        public ActionResult<ApiResult> AddLead([FromBody]AddLeadDto dto)
        {
            return addLead.Execute(dto);
        }
        [HttpPost]
        public ActionResult<ApiResult> EditLead([FromBody]EditLeadDto dto)
        {
            return editLead.Execute(dto);
        }

        [HttpGet]
        public ActionResult<GetLeadsByPageResultDto> GetLeadsByPage([FromQuery]GetLeadsByPageDto dto)
        {
            return getLeadsByPage.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetLeadByIdResultDto> GetLeadById([FromQuery]GetLeadByIdDto dto)
        {
            return getLeadById.Execute(dto);
        }


    }
}
