using Core.Entities.Dto;
using Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ApplicationServices
{
    public interface ISendImage : IApplicationService
    {
        BaseApiResult Execute(SendImageDto dto);
    }
}
