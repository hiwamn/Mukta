using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Tools.General;

namespace Core.ApplicationServices
{
    public class GetDashboard : IGetDashboard
    {

        private readonly IUnitOfWork unit;
        private readonly IGetAverageExpenseReport getAverageExpenseReport;
        private readonly IGetOnlineUsersReport getOnlineUsersReport;
        private readonly IGetPartiesLocation getPartiesLocation;
        private readonly IGetUserInformationReport getUserInformationReport;

        public GetDashboard(
            IUnitOfWork unit,
            IGetAverageExpenseReport getAverageExpenseReport,
            IGetOnlineUsersReport getOnlineUsersReport,
            IGetPartiesLocation getPartiesLocation,
            IGetUserInformationReport getUserInformationReport
            )
        {
            this.unit = unit;
            this.getAverageExpenseReport = getAverageExpenseReport;
            this.getOnlineUsersReport = getOnlineUsersReport;
            this.getPartiesLocation = getPartiesLocation;
            this.getUserInformationReport = getUserInformationReport;
        }
        public GetDashboardResultDto Execute(GetDashboardDto dto)
        {
            return new GetDashboardResultDto
            {
                Object = new Dashboard
                {
                    ExpenseReport = getAverageExpenseReport.Execute(new GetAverageExpenseReportDto { }).Object,
                    OnlineUsers = getOnlineUsersReport.Execute(new GetOnlineUsersReportDto { }).Object,
                    Parties = getPartiesLocation.Execute(new GetPartiesLocationDto { }).Object,
                    UsersInformation = getUserInformationReport.Execute(new GetUserInformationReportDto { }).Object
                },
                Status = true
            };
        }
    }

    
}
