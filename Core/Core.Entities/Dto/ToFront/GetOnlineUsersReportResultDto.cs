using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetOnlineUsersReportDto 
    {

    }
    public class GetOnlineUsersReportResultDto : BaseApiResult
    {
        public OnlineUsers Object { get; set; }
    }

    public class OnlineUsers
    {
        public int TotalCount { get; set; }
        public List<OnlineUserPerDay>  LastWeek { get; set; }

    }
    public class OnlineUserPerDay
    {
        public string DayName { get; set; }
        public int Count { get; set; }
    }
}
