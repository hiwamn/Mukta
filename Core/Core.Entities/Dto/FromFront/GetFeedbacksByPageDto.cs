using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetFeedbacksByPageDto : BaseByUserPageDto
    {
        public long From { get; set; }
        public long To { get; set; }
        public Guid? CategoryId{ get; set; }
    }
    public class GetFeedbacksByPageResultDto : BaseApiPageResult
    {
        public List<FeedbackDto> Object { get; set; }
    }
}
