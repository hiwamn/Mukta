using Core.ApplicationServices;
using Core.Contracts;
using Core.Entities;
using Core.Entities.Dto;
using Core.Entities.Functions;
using Core.Entities.GlobalSettings;
using Domain.Contract;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.EF.Services
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly IContext ctx;

        public OrderRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public int GetMaxSlNo()
        {
            if (ctx.Orders.Count() == 0)
                return 1;
            return ctx.Orders.Max(p => p.SlNo) + 1;
        }

        public int GetNewCount()
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            return ctx.Orders.
                Where(p => p.CreatedAt > nowStart).Count();
        }

        public OrderDto GetOrderById(GetOrderByIdDto dto)
        {
            return ctx.Orders.
                 Where(p => p.Id == dto.Id.ToGuid()).
                 Include(p => p.InvoiceImages).ThenInclude(p => p.Document).
                 Include(p=>p.Party).ThenInclude(p=>p.User).
                 Include(p=>p.Party).ThenInclude(p=>p.StoreCategories).ThenInclude(p=>p.StoreCategory).
                 Include(p=>p.Party).ThenInclude(p=>p.StoreImages).ThenInclude(p=>p.Document).
                 Select(p => DtoBuilder.CreateOrderDto(p)).
                 FirstOrDefault();
        }

        public List<OrderDto> GetOrdersByPage(GetOrdersByPageDto dto)
        {
            return ctx.Orders.
                 Skip((dto.PageNo - 1) * AdminSettings.Block).
                 Take(AdminSettings.Block).
                 Include(p=>p.Party).ThenInclude(p=>p.User).
                 Where(p =>
                 (dto.UserId == null || p.Party.UserId == dto.UserId)&&                 
                 (dto.PartyId == null || p.PartyId== dto.PartyId)).                 
                 Include(p => p.Party).ThenInclude(p => p.StoreCategories).ThenInclude(p => p.StoreCategory).
                 Include(p => p.Party).ThenInclude(p => p.StoreImages).ThenInclude(p => p.Document).
                 Include(p=>p.InvoiceImages).ThenInclude(p=>p.Document).
                 Select(p => DtoBuilder.CreateOrderDto(p)).
                 ToList();
        }

        public int GetOrdersByPageCount(GetOrdersByPageDto dto)
        {
            return ctx.Orders.
                Include(p => p.Party).ThenInclude(p=>p.User).
                Where(p =>
                 (dto.UserId == null || p.Party.UserId == dto.UserId) &&
                 (dto.PartyId == null || p.PartyId == dto.PartyId)).
                Count();
        }

        public List<FixedDto> Search(SearchDto dto)
        {
            return ctx.Orders.Include(p=>p.Party).
                Where(p => dto.UserId == null || dto.UserId == p.Party.UserId).
                Select(p => new FixedDto { Id = p.Id, Name = p.Party.StoreName, Description = p.Description ,Title = p.Party.StoreAddress}).ToList();
        }
    }
}
