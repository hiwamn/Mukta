using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
        List<FeedbackDto> GetFeedbacksByPage(GetFeedbacksByPageDto dto);
        int GetFeedbacksByPageCount(GetFeedbacksByPageDto dto);
        FeedbackDto GetFeedbackById(GetFeedbackByIdDto dto);
        List<FixedDto> Search(SearchDto dto);
        int GetNewCount();
    }
}
