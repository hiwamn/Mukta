using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using Core.Entities.Functions;
using Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility.Tools.Auth;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class RegisterUser : IRegisterUser
    {
        private readonly IUnitOfWork unit;
        private readonly IEncrypter encrypter;
        private readonly IJwtHandler jwtHandler;

        public RegisterUser(IUnitOfWork unit, IEncrypter encrypter,IJwtHandler jwtHandler)
        {
            this.unit = unit;
            this.encrypter = encrypter;
            this.jwtHandler = jwtHandler;
        }
        public LoginResultDto Execute(RegisterUserDto dto)
        {
           



            var now = Agent.UnixTimeNow();

            User user = new User()
            {
                Email = dto.Email,
                FamilyName = dto.FamilyName,
                Name = dto.Name,
                Mobile = dto.Email,
                CreatedAt = now,
                Device = new List<Device> { new Device { PushId = dto.PushId, CreatedAt = now } },
                CityId = dto.CityId,
                Birthday = dto.Birthday,
                Gender = dto.Gender,
                Status = Enums.EntityStatus.WaitingToSendImage.ToInt()
            };

            var referenceUser = unit.User.GetByEmail(dto.ReferenceMobile);
            if (referenceUser != null)
                user.ReferenceId = referenceUser.Id;
            user.SetPassword(dto.Password, encrypter);
            unit.User.Add(user);
            unit.Complete();
            user.City = unit.City.Get(dto.CityId);
            var result = new LoginResultDto
            {
                Object = DtoBuilder.CreateLoginDto(user),
                Status = true
            };
            result.Object.Token = jwtHandler.Create(user.Id);
            return result;
        }
    }
}
