using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetUserIdentityPhoto : IGetUserIdentityPhoto
    {

        private readonly IUnitOfWork unit;

        public GetUserIdentityPhoto(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetUserIdentityPhotoResultDto Execute(BaseByIdDto dto)
        {
            GetUserIdentityPhotoResultDto result = new GetUserIdentityPhotoResultDto { Status = true };
            UserImage image = unit.UserImages.GetByUser(dto);
            if(image != null)
                result.Object = new IdentityImage {Location = image.Document.Location,ImageId = image.Id }; 
            return result;
        }
    }

    
}
