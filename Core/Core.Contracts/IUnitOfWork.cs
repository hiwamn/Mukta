using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IUnitOfWork
    {
        ICityRepository City{ get; set; }
        ICountryRepository Country{ get; set; }
        IProvinceRepository Province{ get; set; }
        IDocumentRepository Document{ get; set; }
        IActiveCodeRepository ActiveCode { get; set; }
        IDeviceRepository Device { get; set; }
        IEntityStatusRepository EntityStatus{ get; set; }
        INotificationRepository Notification { get; set; }
        ISettingRepository Setting{ get; set; }
        IUpdateRepository Update{ get; set; }
        ILeadDocumentsRepository LeadDocuments { get; set; }
        ILeadRepository Lead{ get; set; }
        ILeadStoreCategoriesRepository LeadStoreCategories{ get; set; }
        IOrderDocumentsRepository OrderDocuments{ get; set; }
        IOrderRepository Order{ get; set; }
        IExpenseCategoryRepository ExpenseCategory{ get; set; }
        IExpenseRepository Expense{ get; set; }
        IFeedbackRepository Feedback{ get; set; }
        IPartyRepository Party{ get; set; }
        IPartyDocumentsRepository PartyDocuments{ get; set; }
        IPartyStoreCategoriesRepository PartyStoreCategories{ get; set; }
        IPartyTypeRepository PartyType { get; set; }
        IProductCategoryRepository ProductCategory{ get; set; }
        IRoleRepository Role{ get; set; }
        IStoreCategoryRepository StoreCategory{ get; set; }
        IUserRepository User{ get; set; }
        IUserRoleRepository UserRole{ get; set; }
        IWorkTimeRepository WorkTime{ get; set; }
        IUserImageRepository UserImages{ get; set; }


        void Complete();
    }
}
