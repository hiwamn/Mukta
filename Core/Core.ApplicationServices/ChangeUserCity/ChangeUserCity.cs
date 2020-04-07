using Core.Contracts;
using Core.Entities.Dto;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class ChangeUserCity : IChangeUserCity
    {

        private readonly IUnitOfWork unit;

        public ChangeUserCity(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public BaseApiResult Execute(ChangeUserCityDto dto)
        {               
            var result = new BaseApiResult { Message = Messages.UserNotExist };
            var user = unit.User.Get(dto.UserId);
            if (user != null)
            {
                user.CityId = dto.CityId;
                unit.Complete();
                result.Message =  Messages.OK;
                result.Status = true;
            }
            return result;
        }
    }
}
