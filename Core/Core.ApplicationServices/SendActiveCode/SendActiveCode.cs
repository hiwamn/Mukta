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
    public class SendActiveCode : ISendActiveCode
    {
        private readonly IUnitOfWork unit;
        private readonly INotification notification;

        public SendActiveCode(IUnitOfWork unit,INotification notification)
        {
            this.unit = unit;
            this.notification = notification;
        }

        public BaseApiResult Execute(SendActiveCodeDto dto)
        {
            BaseApiResult result = new BaseApiResult { Message = Messages.LimitExceeded };
            var now = Agent.UnixTimeNow();
            
            if ( unit.User.IsExist(dto.Email))
                result.Message = Messages.UserIsExist;
            else
            {
                string Code = Agent.GenerateRandomNo(6);
                unit.ActiveCode.Add(new ActiveCode() { Mobile = dto.Email, Code = Code, CreatedAt= now });
                unit.Complete();
                //Api.GetRequest($"http://email.iranpetrolbrand.com/home/index?Text= {Code}&Email={dto.Email}");
                Task myTask = Task.Run(() => notification.SendAsync(Code, dto.Email));
                myTask.Wait();
                result.Message = Messages.OK;
                result.Status = true;
            }

            return result;
        }
    }
}
