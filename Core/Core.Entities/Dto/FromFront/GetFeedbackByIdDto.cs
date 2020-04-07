using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetFeedbackByIdDto : BaseByIdDto
    {

    }
    public class GetFeedbackByIdResultDto : BaseApiResult
    {
        public FeedbackDto Object { get; set; }
    }
}
