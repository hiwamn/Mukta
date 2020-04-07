using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IUserImageRepository : IRepository<UserImage>
    {
        UserImage GetByUser(BaseByIdDto dto);
    }
}
