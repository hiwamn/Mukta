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
    public class UserController : AuthorizedController
    {
        private readonly IChangeUserStatus changeUserStatus;
        private readonly IEditProfile editProfile;
        private readonly ISendImage sendImage;
        private readonly ISearch search;

        public UserController(
            IChangeUserStatus changeUserStatus,
            IEditProfile setProfileImage,
            ISendImage sendImage,
            ISearch search
            )
        {
            this.changeUserStatus = changeUserStatus;
            this.editProfile = setProfileImage;
            this.sendImage = sendImage;
            this.search = search;
        }


        [HttpPost]
        public ActionResult<BaseApiResult> AdminChangeUserStatus([FromBody]ChangeUserStatusDto dto)
        {
            return changeUserStatus.Execute(dto);
        }
        [HttpPost]
        public ActionResult<BaseApiResult> SendImage([FromBody]SendImageDto dto)
        {
            return sendImage.Execute(dto);
        }
        [HttpPost]
        public ActionResult<BaseApiResult> EditProfile([FromBody]EditProfileDto dto)
        {
            return editProfile.Execute(dto);
        }
        [HttpGet]
        public ActionResult<SearchResultDto> Search([FromQuery]SearchDto dto)
        {
            return search.Execute(dto);
        }



    }
}
