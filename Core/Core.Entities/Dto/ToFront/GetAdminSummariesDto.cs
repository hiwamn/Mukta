using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetAdminSummariesDto
    {

    }
    public class GetAdminSummariesResultDto : BaseApiResult
    {
        public Summary Object { get; set; }
    }

    public class Summary
    {
        public int NewUsersCount { get; set; }
        public int NewPartiesCount { get; set; }
        public int NewExpensesCount { get; set; }
        public int NewOrdersCount { get; set; }
        public int NewFeedbacksCount { get; set; }
        public int NewLeadsCount { get; set; }
        public int NewWaitingUsersCount { get; set; }
    }

   


}
