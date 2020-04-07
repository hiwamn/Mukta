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
    public class GetOnlineUsersReport : IGetOnlineUsersReport
    {
        private readonly IUnitOfWork unit;

        public GetOnlineUsersReport(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public GetOnlineUsersReportResultDto Execute(GetOnlineUsersReportDto dto)
        {
            return new GetOnlineUsersReportResultDto
            {
                Status = true,
                Object = unit.User.GetOnlineReport(dto)
            };
        }
    }

    
}
