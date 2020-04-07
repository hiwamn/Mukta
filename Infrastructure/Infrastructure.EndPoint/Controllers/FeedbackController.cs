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
    public class FeedbackController : AuthorizedController
    {
        private readonly IAddFeedback addFeedback;
        private readonly IGetFeedbacksByPage getFeedbacksByPage;
        private readonly IGetFeedbackById getFeedbackById;
        private readonly IEditFeedback editFeedback;

        public FeedbackController(
            IAddFeedback addFeedback,
            IGetFeedbacksByPage getFeedbacksByPage,
            IGetFeedbackById getFeedbackById,
            IEditFeedback editFeedback
            )
        {
            this.addFeedback = addFeedback;
            this.getFeedbacksByPage = getFeedbacksByPage;
            this.getFeedbackById = getFeedbackById;
            this.editFeedback = editFeedback;
        }
        [HttpPost]
        public ActionResult<ApiResult> AddFeedback([FromBody]AddFeedbackDto dto)
        {
            return addFeedback.Execute(dto);
        }
        [HttpPost]
        public ActionResult<ApiResult> EditFeedback([FromBody]EditFeedbackDto dto)
        {
            return editFeedback.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetFeedbacksByPageResultDto> GetFeedbacksByPage([FromQuery]GetFeedbacksByPageDto dto)
        {
            return getFeedbacksByPage.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetFeedbackByIdResultDto> GetFeedbackById([FromQuery]GetFeedbackByIdDto dto)
        {
            return getFeedbackById.Execute(dto);
        }



    }
}
