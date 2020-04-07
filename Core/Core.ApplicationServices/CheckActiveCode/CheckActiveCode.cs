using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Utility;
using Utility.Tools.General;
using Utility.Tools.Notification;

namespace Core.ApplicationServices
{
    public class CheckActiveCode : ICheckActiveCode
    {
        private readonly IUnitOfWork unit;


        public CheckActiveCode(IUnitOfWork unit)
        {
            this.unit = unit;

        }

        public BaseApiResult Execute(CheckActiveCodeDto dto)
        {
            var Result = new BaseApiResult { Message = Messages.NotOK };
            if (unit.ActiveCode.CheckActiveCode(dto))
            {
                Result.Message = Messages.OK;
                Result.Status = true;
            }
            return Result;
        }
    }
}
