using Core.Entities.Dto;
using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Functions
{
    public class DtoBuilder
    {

        public static UserLoginDto CreateLoginDto(User user)
        {
            return new UserLoginDto
            {
                Id = user.Id,
                Name = user.Name,
                FamilyName = user.FamilyName,
                Mobile = user.Mobile,
                RegisterDate = user.CreatedAt,
                CityId = user.CityId,
                CityName = user.City?.Name,
                ProfileImage = user.ProfileImage?.Location
            };
        }
        public static UserDto CreateUserDto(User user)
        {
            var isOnline = user.WorkTime.OrderByDescending(p => p.CreatedAt).FirstOrDefault()?.IsInput;
            var lastSignOut = user.WorkTime.Where(p => !p.IsInput).OrderByDescending(p => p.CreatedAt).ToList().FirstOrDefault()?.CreatedAt;
            var lastSignIn = user.WorkTime.Where(p => p.IsInput).OrderByDescending(p => p.CreatedAt).ToList().FirstOrDefault()?.CreatedAt;
            return new UserDto
            {
                Birthday = user.Birthday.Value,
                CityName = user.City?.Name,
                CreatedAt = user.CreatedAt,
                Email = user.Email,
                Name = $"{user.Name} {user.FamilyName}",
                Gender = user.Gender.Value,
                Id = user.Id,
                ProfileImage = user.ProfileImage?.Location,
                Mobile = user.Mobile,
                ProvinceName = user.City?.Province.Name,
                CityId = user.CityId,
                IsActive = user.Status == Enums.EntityStatus.Active.ToInt(),
                IsOnline = isOnline != null && isOnline.Value,
                ProvinceId = user.City?.ProvinceId,
                TotalExpense = user.Expense.Sum(p => p.Amount),
                LastSignOut = lastSignOut,
                LastSignIn = lastSignIn,
                Status = user.Status
            };
        }
        public static FeedbackDto CreateFeedbackDto(Feedback p)
        {
            return new FeedbackDto
            {
                Name = p.Name,
                Description = p.Description,
                Duration = p.Duration,
                StatusId = p.StatusId,
                Party = CreatePartyDto(p.Party)
            };
        }
        public static PartyDto CreatePartyDto(Party p)
        {
            return new PartyDto
            {
                ContractNumber = p.ContractNumber,
                CreatedAt = p.CreatedAt,
                CreditLimit = p.CreditLimit,
                GstStatus = p.GstStatus,
                Id = p.Id,
                Investment = p.Investment,
                OtherCompanyRepresented = p.OtherCompanyRepresented,
                StatusId = p.StatusId,
                StoreAddress = p.StoreAddress,
                StoreCategories = p.StoreCategories.Select(q => new StoreCategoryDto { Id = q.StoreCategoryId, Name = q.StoreCategory.Name }).ToList(),
                StoreEmail = p.StoreEmail,
                StoreImages = p.StoreImages.Select(q => q.Document.Location).ToList(),
                StoreLat = p.StoreLat,
                StoreLon = p.StoreLon,
                StoreName = p.StoreName,
                StoreNumber = p.StoreNumber,
                TotalOutput = p.TotalOutput,
                TypeId = p.TypeId,
                UpdatedAt = p.UpdatedAt,
                User = new UserShoerDto {Id = p.UserId,Name =$"{p.User.Name} {p.User.FamilyName}" }
            };
        }
        public static PartyShortDto CreateShortPartyDto(Party p)
        {
            return new PartyShortDto
            {
                Id = p.Id,
                StoreImages = p.StoreImages.Select(q => q.Document.Location).ToList(),
                StoreLat = p.StoreLat,
                StoreLon = p.StoreLon,
                StoreName = p.StoreName
            };
        }

        public static ExpenseDto CreateExpenseDto(Expense p)
        {
            return new ExpenseDto
            {
                Name = p.Name,
                Amount = p.Amount,
                Categories = p.Categories.Select(q => new StoreCategoryDto { Id = q.StoreCategoryId, Name = q.StoreCategory.Name }).ToList(),
                CreatedAt = p.CreatedAt,
                Id = p.Id,
                Lat = p.Lat,
                Lon = p.Lon,
                StatusId = p.StatusId,
            };
        }

        public static OrderDto CreateOrderDto(Order p)
        {
            return new OrderDto
            {
                Name = p.Name,
                CreatedAt = p.CreatedAt,
                DeliveryPeriod = p.DeliveryPeriod,
                Description = p.Description,
                Discount = p.Discount,
                Id = p.Id,
                Insurance = p.Insurance,
                InvoiceImages = p.InvoiceImages.Select(q => q.Document.Location).ToList(),
                ItemCode = p.ItemCode,
                NetPrice = p.NetPrice,
                PaymentTerms = p.PaymentTerms,
                PurchaseOrderValidityDate = p.PurchaseOrderValidityDate,
                Quantity = p.Quantity,
                RatePerUnit = p.RatePerUnit,
                SaleTax = p.SaleTax,
                SlNo = p.SlNo,
                StatusId = p.StatusId,
                Days = p.Days,
                Party = CreatePartyDto(p.Party),
                DayCount = p.DayCount
            };
        }

        public static LeadDto CreateLeadDto(Lead lead)
        {
            return new LeadDto
            {
                CreatedAt = lead.CreatedAt,
                Id = lead.Id,
                StatusId = lead.StatusId,
                StoreAddress = lead.StoreAddress,
                StoreEmail = lead.StoreEmail,
                StoreLat = lead.StoreLat,
                StoreLon = lead.StoreLon,
                StoreName = lead.StoreName,
                StoreCategories = lead.StoreCategories.Select(p => new StoreCategoryDto { Id = p.StoreCategoryId, Name = p.StoreCategory.Name }).ToList(),
                StoreNumber = lead.StoreNumber,
                UpdatedAt = lead.UpdatedAt,
                StoreImages = lead.StoreImages.Select(p => p.Document.Location).ToList(),
                CreditLimit = lead.CreditLimit,
                GstStatus = lead.GstStatus,
                Investment = lead.Investment,
                OtherCompanyRepresented = lead.OtherCompanyRepresented,
                TypeId = lead.TypeId,
                User = new UserShoerDto { Id = lead.UserId,Name = lead.User.Name}
            };
        }
    }
}
