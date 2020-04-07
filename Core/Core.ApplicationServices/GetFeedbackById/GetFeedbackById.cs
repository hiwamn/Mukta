using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetFeedbackById : IGetFeedbackById
    {

        private readonly IUnitOfWork unit;

        public GetFeedbackById(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetFeedbackByIdResultDto Execute(GetFeedbackByIdDto dto)
        {
            GetFeedbackByIdResultDto result = new GetFeedbackByIdResultDto { Status = true};
            FeedbackDto lst = unit.Feedback.GetFeedbackById(dto);
            result.Object = lst;
            return result;
        }
    }

    
}
