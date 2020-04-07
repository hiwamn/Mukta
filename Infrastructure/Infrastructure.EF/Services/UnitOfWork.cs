using Core.Contracts;
using Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(
            IContext ctx,
            ICityRepository City,
            ICountryRepository Country,
            IProvinceRepository Province,
            IDocumentRepository Document,
            IActiveCodeRepository ActiveCode,
            IDeviceRepository Device,
            IEntityStatusRepository EntityStatus,
            INotificationRepository Notification,
            ISettingRepository Setting,
            IUpdateRepository Update,
            ILeadDocumentsRepository LeadDocuments,
            ILeadRepository Lead,
            ILeadStoreCategoriesRepository LeadStoreCategories,
            IOrderDocumentsRepository OrderDocuments,
            IOrderRepository Order,
            IExpenseCategoryRepository ExpenseCategory,
            IExpenseRepository Expense,
            IFeedbackRepository Feedback,
            IPartyRepository Party,
            IPartyDocumentsRepository PartyDocuments,
            IPartyStoreCategoriesRepository PartyStoreCategories,
            IPartyTypeRepository PartyType,
            IProductCategoryRepository ProductCategory,
            IRoleRepository Role,
            IStoreCategoryRepository StoreCategory,
            IUserRepository User,
            IUserRoleRepository UserRole,
            IWorkTimeRepository WorkTime,
            IUserImageRepository UserImages
            )
        {
            this.ctx = ctx;
            this.City = City;
            this.Country = Country;
            this.Province = Province;
            this.Document = Document;
            this.ActiveCode = ActiveCode;
            this.Device = Device;
            this.EntityStatus = EntityStatus;
            this.Notification = Notification;
            this.Setting = Setting;
            this.Update = Update;
            this.LeadDocuments = LeadDocuments;
            this.Lead = Lead;
            this.LeadStoreCategories = LeadStoreCategories;
            this.OrderDocuments = OrderDocuments;
            this.Order = Order;
            this.ExpenseCategory = ExpenseCategory;
            this.Expense = Expense;
            this.Feedback = Feedback;
            this.Party = Party;
            this.PartyDocuments = PartyDocuments;
            this.PartyStoreCategories = PartyStoreCategories;
            this.PartyType = PartyType;
            this.ProductCategory = ProductCategory;
            this.Role = Role;
            this.StoreCategory = StoreCategory;
            this.User = User;
            this.UserRole = UserRole;
            this.WorkTime = WorkTime;
            this.UserImages = UserImages;
        }
        public IContext  ctx{ get; set; }
        public ICityRepository City { get; set; }
        public ICountryRepository Country { get; set; }
        public IProvinceRepository Province { get; set; }
        public IDocumentRepository Document { get; set; }
        public IActiveCodeRepository ActiveCode { get; set; }
        public IDeviceRepository Device { get; set; }
        public IEntityStatusRepository EntityStatus { get; set; }
        public INotificationRepository Notification { get; set; }
        public ISettingRepository Setting { get; set; }
        public IUpdateRepository Update { get; set; }
        public ILeadDocumentsRepository LeadDocuments { get; set; }
        public ILeadRepository Lead { get; set; }
        public ILeadStoreCategoriesRepository LeadStoreCategories{ get; set; }
        public IOrderDocumentsRepository OrderDocuments { get; set; }
        public IOrderRepository Order { get; set; }
        public IExpenseCategoryRepository ExpenseCategory { get; set; }
        public IExpenseRepository Expense { get; set; }
        public IFeedbackRepository Feedback { get; set; }
        public IPartyRepository Party { get; set; }
        public IPartyDocumentsRepository PartyDocuments { get; set; }
        public IPartyStoreCategoriesRepository PartyStoreCategories { get; set; }
        public IPartyTypeRepository PartyType { get; set; }
        public IProductCategoryRepository ProductCategory { get; set; }
        public IRoleRepository Role { get; set; }
        public IStoreCategoryRepository StoreCategory { get; set; }
        public IUserRepository User { get; set; }
        public IUserRoleRepository UserRole { get; set; }
        public IWorkTimeRepository WorkTime { get; set; }
        public IUserImageRepository UserImages{ get; set; }

        public void Complete()
        {
            ctx.SaveChanges();
        }
    }
}
