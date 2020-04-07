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
    public class LeadRepository : Repository<Lead>, ILeadRepository
    {
        private readonly IContext ctx;

        public LeadRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public LeadDto GetLeadById(GetLeadByIdDto dto)
        {
                return ctx.Leads.
                Where(p=>p.Id== dto.Id.ToGuid()).
                Include(p=>p.StoreImages).ThenInclude(p=>p.Document).
                Include(p => p.StoreCategories).ThenInclude(p => p.StoreCategory).
                Include(p=>p.User).
                Select(p=>DtoBuilder.CreateLeadDto(p)).
                FirstOrDefault();
        }

        public List<LeadDto> GetLeadsByPage(GetLeadsByPageDto dto)
        {
            return ctx.Leads.
                Skip((dto.PageNo-1) * AdminSettings.Block).
                Take(AdminSettings.Block).
                Where(p=>dto.UserId == null|| p.UserId == dto.UserId).
                Include(p=>p.StoreImages).ThenInclude(p=>p.Document).
                Include(p=>p.StoreCategories).ThenInclude(p=>p.StoreCategory).
                Include(p => p.User).
                Select(p=>DtoBuilder.CreateLeadDto(p)).
                ToList();
        }

        public int GetLeadsByPageCount(GetLeadsByPageDto dto)
        {
            return ctx.Leads.
                Where(p =>dto.UserId == null || p.UserId == dto.UserId).
                Count();
        }

        public int GetNewCount()
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            return ctx.Leads.
                Where(p => p.CreatedAt > nowStart).Count();
        }

        public List<FixedDto> Search(SearchDto dto)
        {
            return ctx.Leads.
                Where(p => dto.UserId == null || dto.UserId == p.UserId).
                Select(p => new FixedDto { Id = p.Id, Name = p.StoreName, Description = p.StoreNumber.ToString(),Title=p.StoreAddress }).ToList();
        }
    }
}
