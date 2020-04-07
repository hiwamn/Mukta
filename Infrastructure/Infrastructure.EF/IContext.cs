
using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.EF
{
    public interface IContext 
    {                
        DbSet<Lead> Leads { get; set; }
        DbSet<LeadStoreCategories> LeadStoreCategories{ get; set; }
        DbSet<LeadDocuments> LeadDocuments { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDocuments> OrderDocuments { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Province> Provinces { get; set; }
        DbSet<Document> Documents { get; set; }
        DbSet<ActiveCode> ActiveCodes { get; set; }
        DbSet<Device> Devices { get; set; }
        DbSet<EntityStatus> EntityStatuses { get; set; }
        DbSet<Notification> Notifications { get; set; }
        DbSet<Setting> Settings { get; set; }
        DbSet<Update> Updates { get; set; }        
        DbSet<Expense> Expenses { get; set; }
        DbSet<ExpenseCategory> ExpenseCategories{ get; set; }
        DbSet<Feedback> Feedbacks{ get; set; }
        DbSet<Party> Parties { get; set; }
        DbSet<PartyDocuments> PartyDocuments { get; set; }
        DbSet<PartyStoreCategories> PartyStoreCategories{ get; set; }
        DbSet<PartyType> PartyTypes { get; set; }
        DbSet<ProductCategory> ProductCategories{ get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<StoreCategory> StoreCategories{ get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<WorkTime> WorkTimes{ get; set; }
        DbSet<UserImage> UserImages{ get; set; }

        void SaveChanges();
        

    }
}