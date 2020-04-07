using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using Core.Entities.Functions;
using Core.Entities.GlobalSettings;
using Domain.Contract;
using Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Utility;

namespace Infrastructure.EF.Services
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly IContext ctx;

        public UserRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public User GetByEmail(string email)
        {
            return ctx.Users.Where(p => p.Email == email).Include(p => p.City).Include(p => p.ProfileImage).FirstOrDefault();
        }

        public User GetByEmailIncludingRoles(string email)
        {
            return ctx.Users.Where(p => p.Email == email).Include(p => p.City).Include(p => p.ProfileImage).Include(p => p.UserRole).FirstOrDefault();
        }

        public int GetNewCount()
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            return ctx.Users.
                Where(p=>p.CreatedAt>nowStart).Count();
        }

        public OnlineUsers GetOnlineReport(GetOnlineUsersReportDto dto)
        {
            var week = DateTime.Now.SubDays(7);
            var users = ctx.Users.Include(p => p.WorkTime).ToList();
            List<WorkTime> group = users.Where(p =>
           {
               return p.WorkTime.Any(q => q.IsInput && q.CreatedAt.SubDays(0) > week);
           }).ToList().SelectMany(p => p.WorkTime.Where(q => q.IsInput)).OrderByDescending(p => p.CreatedAt).ToList();


            var onlineCount = users.Where(p =>
            {
                var result = p.WorkTime.OrderByDescending(q => q.CreatedAt).FirstOrDefault()?.IsInput;
                return result.HasValue;

            }).Count();
            return new OnlineUsers
            {
                TotalCount = onlineCount,
                LastWeek = group.GroupBy(p => p.CreatedAt.DayName()).Select(t => new OnlineUserPerDay { DayName = t.Key, Count = t.ToList().Count }).ToList()
            };
        }

        public GenericUsers GetUserInformationReport(GetUserInformationReportDto dto)
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            var users = ctx.Users.ToList();
            List<DayUserReport> week = new List<DayUserReport>();

            var lastWeekStart = DateTime.Now.SubDays(-DateTime.Now.DayOfWeek.ToInt() - 7);
            var lastWeekEnd = DateTime.Now.SubDays(-DateTime.Now.DayOfWeek.ToInt());

            var weekUsers = users.Where(p => p.CreatedAt >= lastWeekStart.ToUnix() && p.CreatedAt <= lastWeekEnd.ToUnix()).ToList();
            for (int i = 0; i < 7; i++)
            {
                var start = lastWeekStart.SubDays(i).ToUnix();
                var end = lastWeekStart.SubDays(i+1).ToUnix();
                lastWeekStart = lastWeekStart.SubDays(1);
                week.Add(
                    new DayUserReport 
                    { 
                        DayName = start.DayName(), 
                        NewUsers = weekUsers.Where(p => p.CreatedAt >= start && p.CreatedAt <= end).Count(), 
                        LoggedInUsers = weekUsers.Where(q => q.WorkTime.Any(p=> p.CreatedAt >= start && p.CreatedAt <= end)).Count()
                    });
            }
            return new GenericUsers
            {
                FemaleCount = users.Where(p=>p.Gender == Genders.Female.ToInt()).Count(),
                MaleCount = users.Where(p => p.Gender == Genders.Male.ToInt()).Count(),
                UnKnownCount = users.Where(p => p.Gender == null).Count(),
                NewUsers = users.Where(p=>p.CreatedAt > nowStart).Count(),
                UserCount = users.Count,
                BestUsers = 0,
                TotalLoggedIn = users.Where(p => p.WorkTime.Any(q=>q.CreatedAt>nowStart)).Count(),
                WeekUserReport = week
            };
            
        }

        public List<UserDto> GetUsersByPage(GetUsersByPageDto dto)
        {
            return ctx.Users.
                Where(p=>dto.Status == null || p.Status == dto.Status.Value).
                OrderByDescending(p => p.CreatedAt).
                Skip((dto.PageNo - 1) * AdminSettings.Block).
                Take(AdminSettings.Block).
                Include(p => p.WorkTime).
                Include(p => p.Expense).
                Include(p => p.City).ThenInclude(p => p.Province).
                Include(p => p.ProfileImage).
                Select(p => DtoBuilder.CreateUserDto(p)).
                ToList();

        }

        public int GetWaitingUsersCount()
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            return ctx.Users.
                Where(p => p.Status == Enums.EntityStatus.ImageHasBeenSent.ToInt()).Count();
        }

        public bool IsExist(string Email)
        {
            return ctx.Users.Any(p => p.Email == Email);
        }


    }
}
