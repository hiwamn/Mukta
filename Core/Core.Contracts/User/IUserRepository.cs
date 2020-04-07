using Core.Entities;
using Core.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IUserRepository : IRepository<User>
    {
        bool IsExist(string email);
        User GetByEmail(string email);
        List<UserDto> GetUsersByPage(GetUsersByPageDto dto);
        OnlineUsers GetOnlineReport(GetOnlineUsersReportDto dto);
        User GetByEmailIncludingRoles(string email);
        GenericUsers GetUserInformationReport(GetUserInformationReportDto dto);
        int GetNewCount();
        int GetWaitingUsersCount();
    }
}
