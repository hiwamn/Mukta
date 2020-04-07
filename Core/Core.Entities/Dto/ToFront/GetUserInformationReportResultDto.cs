using System;
using System.Collections.Generic;

namespace Core.Entities.Dto
{
    public class GetUserInformationReportDto
    {

    }
    public class GetUserInformationReportResultDto : BaseApiResult
    {
        public GenericUsers Object { get; set; }
    }


    
}
