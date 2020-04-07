using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class UpdateProfile : IUpdateProfile
    {
        private readonly IUnitOfWork unit;

        public UpdateProfile(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public BaseApiResult Execute(UpdateProfileDto dto )
        {
            User user = unit.User.Get(dto.Id);
            user.Name = dto.Name;
            user.FamilyName = dto.FamilyName;
            user.CityId = dto.CityId;
            unit.Complete();
            return new BaseApiResult
            {
                Message = Messages.OK,
                Status = true
            };
        }
    }
}
