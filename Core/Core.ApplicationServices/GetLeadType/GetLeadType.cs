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
    public class GetLeadType : IGetLeadType
    {
        private readonly IUnitOfWork unit;

        public GetLeadType(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public ApiResult Execute()
        {
            return new ApiResult
            {
                Object = unit.PartyType.GetAll(),
                Status = true
            };
        }
    }

    
}
