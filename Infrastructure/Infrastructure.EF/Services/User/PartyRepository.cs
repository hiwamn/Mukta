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
    public class PartyRepository : Repository<Party>, IPartyRepository
    {
        private readonly IContext ctx;

        public PartyRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public int GetNewCount()
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            return ctx.Parties.
                Where(p => p.CreatedAt > nowStart).Count();
        }

        public List<PartyDto> GetPartiesByPage(GetPartiesByPageDto dto)
        {
            return ctx.Parties.
                 Skip((dto.PageNo - 1) * AdminSettings.Block).
                 Take(AdminSettings.Block).
                 Where(p => dto.UserId == null || p.UserId == dto.UserId).
                 Include(p=>p.StoreCategories).ThenInclude(p=>p.StoreCategory).
                 Include(p=>p.StoreImages).ThenInclude(p=>p.Document).
                 Where(p=>dto.Keyword == null || dto.Keyword == "" 
                 || p.StoreName.Contains(dto.Keyword)
                 || p.ContractNumber.Contains(dto.Keyword)
                 || p.StoreAddress.Contains(dto.Keyword)
                 || p.StoreNumber.Contains(dto.Keyword)
                 ).
                 Include(p=>p.User).
                 Select(p => DtoBuilder.CreatePartyDto(p)).
                 ToList();
        }

        public int GetPartiesByPageCount(GetPartiesByPageDto dto)
        {
            return ctx.Parties.
                Where(p => dto.UserId == null || p.UserId == dto.UserId).
                Count();
        }

        public List<PartyShortDto> GetPartiesLocation(GetPartiesLocationDto dto)
        {
            return ctx.Parties.
                 Include(p => p.StoreCategories).ThenInclude(p => p.StoreCategory).
                 Include(p => p.StoreImages).ThenInclude(p => p.Document).
                 Select(p => DtoBuilder.CreateShortPartyDto(p)).
                 ToList();
        }

        public PartyDto GetPartyById(GetPartyByIdDto dto)
        {
            return ctx.Parties.
                 Where(p => p.Id == dto.Id.ToGuid()).
                 Include(p => p.StoreCategories).ThenInclude(p => p.StoreCategory).
                 Include(p => p.StoreImages).ThenInclude(p => p.Document).
                 Include(p => p.User).
                 Select(p => DtoBuilder.CreatePartyDto(p)).
                 FirstOrDefault();
        }

        public List<FixedDto> Search(SearchDto dto)
        {
            return ctx.Parties.
                Where(p => dto.UserId == null || dto.UserId == p.UserId).
                Select(p => new FixedDto { Id = p.Id, Name = p.StoreName, Description = p.StoreNumber, Title = p.StoreAddress}).ToList();
        }
    }
}
