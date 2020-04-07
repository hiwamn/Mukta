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
    public class FeedbackRepository : Repository<Feedback>, IFeedbackRepository
    {
        private readonly IContext ctx;

        public FeedbackRepository(IContext ctx) : base(ctx as DbContext)
        {
            this.ctx = ctx;
        }

        public FeedbackDto GetFeedbackById(GetFeedbackByIdDto dto)
        {
            return ctx.Feedbacks.
                 Include(p => p.Party).ThenInclude(p => p.StoreCategories).ThenInclude(p => p.StoreCategory).
                 Where(p =>p.Id == dto.Id).
                 Include(p => p.Party).ThenInclude(p => p.StoreImages).ThenInclude(p => p.Document).
                 Include(p => p.Party).ThenInclude(p => p.User).
                 Select(p => DtoBuilder.CreateFeedbackDto(p)).
                 FirstOrDefault();
        }

        public List<FeedbackDto> GetFeedbacksByPage(GetFeedbacksByPageDto dto)
        {
            return ctx.Feedbacks.
                 Skip((dto.PageNo - 1) * AdminSettings.Block).
                 Take(AdminSettings.Block).
                 Include(p => p.Party).ThenInclude(p => p.StoreCategories).ThenInclude(p => p.StoreCategory).
                 Where(p =>
                 (dto.UserId == null || p.Party.UserId == dto.UserId) && 
                 (dto.From == 0 || (p.CreatedAt >= dto.From && p.CreatedAt<= dto.To))&&
                 (dto.CategoryId == null ||  p.Party.StoreCategories.Any(q=>q.StoreCategoryId == dto.CategoryId))).
                 Include(p => p.Party).ThenInclude(p => p.StoreImages).ThenInclude(p => p.Document).
                 Include(p => p.Party).ThenInclude(p => p.User).
                 Select(p => DtoBuilder.CreateFeedbackDto(p)).
                 ToList();
        }

        public int GetFeedbacksByPageCount(GetFeedbacksByPageDto dto)
        {
            return ctx.Feedbacks.Include(p => p.Party).
                Where(p => dto.UserId == null || p.Party.UserId == dto.UserId).
                Count();
        }

        public int GetNewCount()
        {
            var nowStart = DateTime.Now.SubDays(0).ToUnix();
            return ctx.Feedbacks.
                Where(p => p.CreatedAt > nowStart).Count();
        }

        public List<FixedDto> Search(SearchDto dto)
        {
            return ctx.Feedbacks.
                Include(p=>p.Party).
                Where(p => dto.UserId == null || dto.UserId == p.Party.UserId).
                Select(p => new FixedDto { Id = p.Id, Name = p.Party.StoreName, Description = p.Description, Title  = p.Party.StoreName}).ToList();
        }
    }
}
