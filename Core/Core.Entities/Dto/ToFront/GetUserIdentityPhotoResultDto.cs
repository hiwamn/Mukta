
using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetUserIdentityPhotoResultDto : BaseApiResult
    {
        public IdentityImage Object { get; set; }
    }
    public class IdentityImage
    {
        public Guid ImageId { get; set; }
        public string Location { get; set; }
    }

   
}
