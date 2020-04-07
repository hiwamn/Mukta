using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
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
    public class UserImageRepository : Repository<UserImage>, IUserImageRepository
    {
        private readonly IContext ctx;

        public UserImageRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public UserImage GetByUser(BaseByIdDto dto)
        {
            return ctx.UserImages.Where(p => p.UserId == dto.Id).
                Include(p => p.Document).
                OrderByDescending(p => p.CreatedAt).FirstOrDefault();
        }
    }
}
