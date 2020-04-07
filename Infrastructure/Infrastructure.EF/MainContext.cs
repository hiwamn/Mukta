using Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Reflection;

namespace Infrastructure.EF
{
    public class MainContext : DbContext, IContext
    {
        public DbSet<Lead> Leads { get; set; }
        public DbSet<LeadStoreCategories> LeadStoreCategories{ get; set; }
        public DbSet<LeadDocuments> LeadDocuments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDocuments> OrderDocuments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<ActiveCode> ActiveCodes { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<EntityStatus> EntityStatuses { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<PartyDocuments> PartyDocuments { get; set; }
        public DbSet<PartyStoreCategories> PartyStoreCategories { get; set; }
        public DbSet<PartyType> PartyTypes { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<StoreCategory> StoreCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }
        public DbSet<UserImage> UserImages{ get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }

        public MainContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Infrastructure.EF")/*, sqlServerOptions => sqlServerOptions.CommandTimeout(600)*/);
            //this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.AddEntityConfiguration();
            builder.SeedData();
        }

        void IContext.SaveChanges()
        {
            this.SaveChanges();
        }
    }
}
