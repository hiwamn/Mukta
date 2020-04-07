using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetFeedbacksByPage : IGetFeedbacksByPage
    {

        private readonly IUnitOfWork unit;

        public GetFeedbacksByPage(IUnitOfWork unit)
        {
            this.unit = unit;
        }
        public GetFeedbacksByPageResultDto Execute(GetFeedbacksByPageDto dto)
        {
            GetFeedbacksByPageResultDto result = new GetFeedbacksByPageResultDto { Status = true,Page = new PageDto { PageNo = dto.PageNo} };
            List<FeedbackDto> lst = unit.Feedback.GetFeedbacksByPage(dto);
            result.Object = lst;
            result.Page.Total = unit.Feedback.GetFeedbacksByPageCount(dto);
            result.Page.CurrentCount = lst.Count;
            return result;
        }
    }

    
}
