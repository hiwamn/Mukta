using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class AddPunch : IAddPunch
    {

        private readonly IUnitOfWork unit;

        public AddPunch(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(AddPunchDto dto)
        {
            ApiResult result = new ApiResult { Status = true,Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();

            WorkTime wt = new WorkTime
            {
                UserId = dto.UserId,
                StatusId = Enums.EntityStatus.Deactive.ToInt(),
                CreatedAt = now,
                Entry = now,
                IsInput = dto.IsInput
            };
            unit.WorkTime.Add(wt);
            unit.Complete();
            result.Object = Agent.ToJson(wt);
            return result;
        }
    }
}
