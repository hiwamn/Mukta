using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ApplicationServices
{
    public interface ICheckActiveCode : IApplicationService
    {
        BaseApiResult Execute(CheckActiveCodeDto dto);
    }
}
