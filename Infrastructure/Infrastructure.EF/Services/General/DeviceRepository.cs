using Core.Contracts;
using Core.Entities;
using Domain.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.EF.Services
{
    public class DeviceRepository : Repository<Device>, IDeviceRepository
    {
        private readonly IContext ctx;

        public DeviceRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public bool IsExist(Guid userId, string deviceId)
        {
            return ctx.Devices.Any(p=>p.UserId == userId && p.PushId == deviceId);
        }

    }
}
