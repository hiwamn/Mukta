using Core.ApplicationServices;
using Core.Contracts;
using Core.Entities;
using Core.Entities.GlobalSettings;
using Domain.Contract;
using Infrastructure.EF.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Utility.Tools;
using Utility.Tools.Auth;
using Utility.Tools.Notification;
using Utility.Tools.SMS.Rahyab;
using Utility.Tools.Swager;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Infrastructure.EF
{
    public static class Extension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            var applicationServiceType = typeof(IApplicationService).Assembly;
            var AllApplicationServices = applicationServiceType.ExportedTypes
               .Where(x => x.IsClass && x.IsPublic && x.FullName.Contains("ApplicationService")).ToList();
            foreach (var type in AllApplicationServices)
            {
                //Console.WriteLine(type.Name);
                services.AddScoped(type.GetInterface($"I{type.Name}"), type);
            }
        }
        public static void AddRepositories(this IServiceCollection services)
        {
            var repositpryType = typeof(Repository<>).Assembly;
            var AllRepositories = repositpryType.ExportedTypes
               .Where(x => x.IsClass && x.IsPublic && x.Name.Contains("Repository") && !x.Name.StartsWith("Repository")).ToList();
            foreach (var type in AllRepositories)
            {
                //Console.WriteLine(type.Name);
                services.AddScoped(type.GetInterface($"I{type.Name}"), type);
            }
        }
        public static void ConfigureServices(this IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            configuration.GetSection<AdminSettings>();
            services.AddApplicationServices();
            services.AddRepositories();
            services.AddSwager();
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("CorsPolicy",
            //        builder => builder.AllowAnyOrigin()
            //        .AllowAnyMethod()
            //        .AllowAnyHeader()
            //        .AllowCredentials());
            //});
            //services.AddMvc(options =>
            //{
            //    //options.Filters.Add(typeof(LogFilterAttribute));
            //    options.Filters.Add(typeof(CustomExceptionFilter));
            //    //options.ModelBinderProviders.Insert(0, new CustomBinderProvider());
            //}).AddSessionStateTempDataProvider().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddJwt(configuration);
            configuration.GetSection<RahyabParameters>();
            services.AddScoped<IContext, MainContext>();
            //services.AddDbContext<MainContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Infrastructure.EndPoint")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEncrypter, Encrypter>();
            services.AddScoped<INotification, RahyabService>();

            configuration.GetSection<RahyabParameters>();
            services.AddJwt(configuration);
            services.AddScoped<IContext, MainContext>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEncrypter, Encrypter>();

            services.AddScoped<INotification, RahyabService>();
            services.AddScoped<IFireBase, FireBase>();

        }


        public static void AddEntityConfiguration(this ModelBuilder builder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                         .Where(t => t.GetInterfaces().Any(gi => gi.IsGenericType && gi.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))).ToList();

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                builder.ApplyConfiguration(configurationInstance);
            }
        }
        public static void SeedData(this ModelBuilder builder)
        {

            builder.Entity<Role>().HasData(new Role { Id = 1, Name = "Mobile" });
            builder.Entity<Role>().HasData(new Role { Id = 2, Name = "Admin" });


            builder.Entity<Country>().HasData(new Country { Id = 1, Name = "India" });
            builder.Entity<Province>().HasData(new Province { Id = 1, Name = "Isfahan", CountryId = 1 });
            builder.Entity<City>().HasData(new City { Id = 1, Name = "Sede", ProvinceId = 1 });
            builder.Entity<City>().HasData(new City { Id = 2, Name = "Shahin Shahr", ProvinceId = 1 });
            builder.Entity<City>().HasData(new City { Id = 3, Name = "Jalal Abad", ProvinceId = 1 });
            builder.Entity<City>().HasData(new City { Id = 4, Name = "Ghahdrijan", ProvinceId = 1 });
            
            
            builder.Entity<EntityStatus>().HasData(new EntityStatus { Id = 0, Name = "Waiting/Deactivated"});
            builder.Entity<EntityStatus>().HasData(new EntityStatus { Id = 1, Name = "Activated/Submited"});
            builder.Entity<EntityStatus>().HasData(new EntityStatus { Id = 2, Name = "Deleted"});
            builder.Entity<EntityStatus>().HasData(new EntityStatus { Id = 3, Name = "Rejected"});
            builder.Entity<EntityStatus>().HasData(new EntityStatus { Id = 4, Name = "WaitingToSendImage"});
            builder.Entity<EntityStatus>().HasData(new EntityStatus { Id = 5, Name = "ImageHasBeenSent"});
            builder.Entity<EntityStatus>().HasData(new EntityStatus { Id = 6, Name = "ImageHasBeenRejected"});

            builder.Entity<PartyType>().HasData(new PartyType { Id = 1, Name = "Direct Dealer"});
            builder.Entity<PartyType>().HasData(new PartyType { Id = 2, Name = "Dealer Account"});
            builder.Entity<PartyType>().HasData(new PartyType { Id = 3, Name = "Distributor"});
            
            
            builder.Entity<StoreCategory>().HasData(new StoreCategory{ Id = Guid.NewGuid(), Name = "Cooktop" });
            builder.Entity<StoreCategory>().HasData(new StoreCategory{ Id = Guid.NewGuid(), Name = "Cooking range" });
            builder.Entity<StoreCategory>().HasData(new StoreCategory{ Id = Guid.NewGuid(), Name = "Chimney" });
            builder.Entity<StoreCategory>().HasData(new StoreCategory{ Id = Guid.NewGuid(), Name = "Hobs" });
            builder.Entity<StoreCategory>().HasData(new StoreCategory{ Id = Guid.NewGuid(), Name = "Cookware" });
            builder.Entity<StoreCategory>().HasData(new StoreCategory{ Id = Guid.NewGuid(), Name = "Cooker" });




            //using (var str = new StreamReader(@"Province.json"))
            //{
            //    var resul = Api.ToObject<List<ProvinceAndCitys>>(str.ReadToEnd());

            //    int provienceCounter = 1, cityCounter = 1;


            //    resul.ForEach(p =>
            //    {
            //        List<City> cities = new List<City>();
            //        p.cities.ForEach(q =>
            //        {
            //            cities.Add(new Core.Entities.City { Name = q.name, ProvinceId = provienceCounter, Id = cityCounter++ });
            //        });
            //        builder.Entity<Province>().HasData(new Core.Entities.Province { Id = provienceCounter++, Name = p.name });
            //        builder.Entity<City>().HasData(cities.ToArray());
            //    });
            //}



        }
    }
}
