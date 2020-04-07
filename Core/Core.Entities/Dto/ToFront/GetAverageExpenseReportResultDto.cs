using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetAverageExpenseReportDto 
    {

    }
    public class GetAverageExpenseReportResultDto : BaseApiResult
    {
        public AverageExpense Object { get; set; }
    }

    public class AverageExpense
    {
        public int TotalCount { get; set; }
        public List<ExpensePerDay> LastThreeYearDays { get; set; }
        public List<ExpensePerMonth> LastThreeYearMonths { get; set; }
        public List<ExpensePerYear> LastThreeYearYears { get; set; }

    }
    public class ExpensePerDay
    {
        public string DayName { get; set; }
        public int Amount { get; set; }
    }
    public class ExpensePerMonth
    {
        public string MonthName { get; set; }
        public int Amount { get; set; }
    }
    public class ExpensePerYear
    {
        public string Year { get; set; }
        public int Amount { get; set; }
    }
}
