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
    public class PartyController : SimpleController
    {
        private readonly IAddParty addParty;
        private readonly IGetPartiesByPage getPartiesByPage;
        private readonly IGetPartyById getPartyById;
        private readonly IEditParty editParty;

        public PartyController(
            IAddParty addParty,
            IGetPartiesByPage getPartiesByPage,
            IGetPartyById getPartyById,
            IEditParty editParty
            )
        {
            this.addParty = addParty;
            this.getPartiesByPage = getPartiesByPage;
            this.getPartyById = getPartyById;
            this.editParty = editParty;
        }

        [HttpPost]
        public ActionResult<ApiResult> AddParty([FromBody]AddPartyDto dto)
        {
            return addParty.Execute(dto);
        }
        [HttpPost]
        public ActionResult<ApiResult> EditParty([FromBody]EditPartyDto dto)
        {
            return editParty.Execute(dto);
        }

        [HttpGet]
        public ActionResult<GetPartiesByPageResultDto> GetPartiesByPage([FromQuery]GetPartiesByPageDto dto)
        {
            return getPartiesByPage.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetPartyByIdResultDto> GetPartyById([FromQuery]GetPartyByIdDto dto)
        {
            return getPartyById.Execute(dto);
        }



    }
}
