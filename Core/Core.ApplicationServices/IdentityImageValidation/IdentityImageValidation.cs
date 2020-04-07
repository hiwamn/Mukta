using Core.Contracts;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class IdentityImageValidation : IIdentityImageValidation
    {
        private readonly IUnitOfWork unit;

        public IdentityImageValidation(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public BaseApiResult Execute(IdentityImageValidationDto dto)
        {
            BaseApiResult result = new BaseApiResult { Message = "کاربر یافت نشد" };

            var user = unit.User.Get(dto.UserId);
            if (dto.IsAccepted)
                user.Status = Enums.EntityStatus.Active.ToInt();
            else
                user.Status = Enums.EntityStatus.ImageHasBeenRejected.ToInt();
            unit.Complete();
            return result;
        }
    }
}
