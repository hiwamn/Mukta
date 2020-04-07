using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetWeeklyIncomeReportDto 
    {

    }
    public class GetWeeklyIncomeReportResultDto : BaseApiResult
    {
        public WeeklyIncome Object { get; set; }
    }

    public class WeeklyIncome
    {
        public int TotalAmount{ get; set; }
        public List<WeeklyIncomePerDay>  LastWeek { get; set; }

    }
    public class WeeklyIncomePerDay
    {
        public string DayName { get; set; }
        public string Amount { get; set; }
    }
}
