using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetAverageExpenseReport : IGetAverageExpenseReport
    {
        private readonly IUnitOfWork unit;

        public GetAverageExpenseReport(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public GetAverageExpenseReportResultDto Execute(GetAverageExpenseReportDto dto)
        {
            return new GetAverageExpenseReportResultDto
            {
                Status = true,
                Object = unit.Expense.GetAverageExpenseReport(dto)
            };
        }
    }

    
}
