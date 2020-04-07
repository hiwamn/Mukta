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
    public class AdminController : SimpleController
    {
        private readonly IGetUsersByPage getUsersByPage;
        private readonly IChangeUserStatus changeUserStatus;
        private readonly IGetDashboard getDashboard;
        private readonly IGetLeadType getLeadType;
        private readonly IGetUserIdentityPhoto getUserIdentityPhoto;
        private readonly IIdentityImageValidation identityImageValidation;
        private readonly IGetAdminSummaries getAdminSummaries;

        public AdminController(
            IGetUsersByPage getUsersByPage,
            IChangeUserStatus changeUserStatus,
            IGetDashboard getDashboard,
            IGetLeadType getLeadType,
            IGetUserIdentityPhoto getUserIdentityPhoto,
            IIdentityImageValidation identityImageValidation,
            IGetAdminSummaries getAdminSummaries
            )
        {
            this.getUsersByPage = getUsersByPage;
            this.changeUserStatus = changeUserStatus;
            this.getDashboard = getDashboard;
            this.getLeadType = getLeadType;
            this.getUserIdentityPhoto = getUserIdentityPhoto;
            this.identityImageValidation = identityImageValidation;
            this.getAdminSummaries = getAdminSummaries;
        }


        [HttpPost]
        public ActionResult<BaseApiResult> ChangeUserStatus([FromBody]ChangeUserStatusDto dto)
        {
            return changeUserStatus.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetUsersByPageResultDto> GetUsersByPage([FromQuery]GetUsersByPageDto dto)
        {
            return getUsersByPage.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetDashboardResultDto> GetDashboard([FromQuery]GetDashboardDto dto)
        {
            return getDashboard.Execute(dto);
        }
        [HttpGet]
        public ActionResult<ApiResult> GetLeadType()
        {
            return getLeadType.Execute();
        }
        [HttpGet]
        public ActionResult<GetUserIdentityPhotoResultDto> GetUserIdentityPhoto([FromQuery]BaseByIdDto dto)
        {
            return getUserIdentityPhoto.Execute(dto);
        }

        [HttpPost]
        public ActionResult<BaseApiResult> IdentityImageValidation([FromBody]IdentityImageValidationDto dto)
        {
            return identityImageValidation.Execute(dto);
        }
        [HttpGet]
        public ActionResult<GetAdminSummariesResultDto> GetAdminSummaries([FromQuery]GetAdminSummariesDto dto)
        {
            return getAdminSummaries.Execute(dto);
        }
    }
}
