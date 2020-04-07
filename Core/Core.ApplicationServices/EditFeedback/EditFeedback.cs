using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class EditFeedback : IEditFeedback
    {

        private readonly IUnitOfWork unit;

        public EditFeedback(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public ApiResult Execute(EditFeedbackDto dto)
        {
            ApiResult result = new ApiResult { Status = true,Message = Messages.Success, };
            var now = DateTime.Now.ToUnix();


            Feedback fee = unit.Feedback.Get(dto.Id);
            fee.Description = dto.Description;
            fee.Duration = dto.Duration;
            fee.Name = dto.Name;
            unit.Complete();
            result.Object = fee;
            return result;
        }
    }
}
