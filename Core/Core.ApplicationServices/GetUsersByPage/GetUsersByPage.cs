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
    public class GetUsersByPage : IGetUsersByPage
    {
        private readonly IUnitOfWork unit;

        public GetUsersByPage(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public GetUsersByPageResultDto Execute(GetUsersByPageDto dto)
        {
            var users = unit.User.GetUsersByPage(dto);
            return new GetUsersByPageResultDto
            {
                Object = users,
                Status = true,
                Page = new PageDto
                {
                    PageNo = dto.PageNo,
                    CurrentCount = users.Count,
                    Total= unit.User.GetCount()
                }
            };
        }
    }

    
}
