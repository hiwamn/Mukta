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
    public class GetUserInformationReport : IGetUserInformationReport
    {
        private readonly IUnitOfWork unit;

        public GetUserInformationReport(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public GetUserInformationReportResultDto Execute(GetUserInformationReportDto dto)
        {
            return new GetUserInformationReportResultDto
            {
                Status = true,
                Object = unit.User.GetUserInformationReport(dto)
            };
        }
    }

    
}
