using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetDashboardDto
    {

    }
    public class GetDashboardResultDto : BaseApiResult
    {
        public Dashboard Object { get; set; }
    }

    public class Dashboard
    {
        public AverageExpense ExpenseReport { get; set; }
        public OnlineUsers OnlineUsers { get; set; }
        public List<PartyShortDto> Parties { get; set; }
        public GenericUsers UsersInformation { get; set; }

    }

    public class GenericUsers
    {
        public int NewUsers { get; set; }
        public int TotalLoggedIn { get; set; }
        public int UserCount { get; set; }
        public int FemaleCount { get; set; }
        public int MaleCount { get; set; }
        public int UnKnownCount { get; set; }
        public int BestUsers { get; set; }

        public List<DayUserReport> WeekUserReport { get; set; }
    }

    public class DayUserReport
    {
        public string DayName { get; set; }
        public int NewUsers{ get; set; }
        public int LoggedInUsers{ get; set; }
    }


}
