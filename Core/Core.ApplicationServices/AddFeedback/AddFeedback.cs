using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class AddFeedback : IAddFeedback
    {

        private readonly IUnitOfWork unit;

        public AddFeedback(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(AddFeedbackDto dto)
        {
            ApiResult result = new ApiResult { Status = true,Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();
            

            Feedback fee = new Feedback
            {
                StatusId = Enums.EntityStatus.Deactive.ToInt(),
                CreatedAt = now,
                Description = dto.Description,
                Duration = dto.Duration,
                PartyId = dto.PartyId,
                Name = dto.Name
            };
            unit.Feedback.Add(fee);
            unit.Complete();
            result.Object = Agent.ToJson(fee);
            return result;
        }
    }
}
