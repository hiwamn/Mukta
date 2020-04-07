using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;
using Utility.Tools.General;
using Utility.Tools.Notification;

namespace Core.ApplicationServices
{
    public class SendImage : ISendImage
    {
        private readonly IUnitOfWork unit;
        

        public SendImage(IUnitOfWork unit)
        {
            this.unit = unit;
        
        }

        public BaseApiResult Execute(SendImageDto dto)
        {
            BaseApiResult result = new BaseApiResult {Status = true};
            var now = Agent.UnixTimeNow();
            var user = unit.User.Get(dto.UserId);
            user.Status = Enums.EntityStatus.ImageHasBeenSent.ToInt();
            UserImage ui = new UserImage {CreatedAt = now,DocumentId = dto.DocumentId,UserId = dto.UserId };
            unit.UserImages.Add(ui);
            unit.Complete();
            return result;
        }
    }
}
