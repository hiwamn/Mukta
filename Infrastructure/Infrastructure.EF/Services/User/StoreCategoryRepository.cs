using Core.ApplicationServices;
using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using Domain.Contract;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.EF.Services
{
    public class StoreCategoryRepository : Repository<StoreCategory>, IStoreCategoryRepository
    {
        private readonly IContext ctx;

        public StoreCategoryRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }
    }
}
