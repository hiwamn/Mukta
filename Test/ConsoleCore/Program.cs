using Domain.Contract;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Core.Contracts;
using Utility.Tools.Auth;
using Infrastructure.EF;
using Utility.Tools.Notification;
using Core.ApplicationServices;
using Utility.Tools.SMS.Rahyab;
using Infrastructure.EndPoint.Controllers;
using Core.Entities.Dto;
using Microsoft.AspNetCore.Hosting;
using Utility.Tools.General;
using Utility.Tools;

namespace ConsoleCore
{
    class Program
    {
        public static IUnitOfWork Iunit { get; private set; }
        public static INotification Notification { get; private set; }
        public static IEncrypter Encrypter { get; private set; }
        public static IJwtHandler JwtHandler { get; private set; }
        public static IConfiguration Configuration { get; set; }
        public static IHostingEnvironment host { get; set; }

        private static IFireBase firebase;

        static async Task Main()
        {
            Config();
            firebase.SendNotification(new List<NotificationObject> { new NotificationObject
            {
                DeviceId = "eT_Rn00vyi4H1qStHVpWrF:APA91bELTkMCUNXaD2125c6H5z8fvQNvMAPZbQI0F9_aNPTwhjCPHu9QF6Fy2JNp2Z4hc5h6ts1TJxpkCB-utuz_wpQM27b_TLg3dyM8ZmwqlDHSkCuzweF8QJkT8kBv6OlJaEdYOjlj",
                Description = "salam",
                Image = "Address",
                Title = "salam",
                Link = "Link",
                Type = 0

            } });  
         

            DocumentController document = new DocumentController(Iunit, host);
            document.SendDocument(Enums.DocumentType.Image);
            EmailService email = new EmailService(Configuration);
            await email.SendAsync("salam", "hiwa_mn@yahoo.com");
                    
            Console.ReadKey();
        }
        public static void Config()
        {
            ServiceCollection service = new ServiceCollection();
            var builder = new ConfigurationBuilder().SetBasePath(@"C:\Projects\Zigorat\Sunblaze\Infrastructure\Infrastructure.EndPoint\").AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).AddEnvironmentVariables();
            Configuration = builder.Build();
            service.AddSingleton<IConfiguration>(builder.Build());
            service.ConfigureServices(Configuration);
            service.AddDbContext<MainContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            var provider = service.BuildServiceProvider();
            Iunit = provider.GetService<IUnitOfWork>();
            Encrypter = provider.GetService<IEncrypter>();
            Notification = provider.GetService<INotification>();
            JwtHandler = provider.GetService<IJwtHandler>();
            host = provider.GetService<IHostingEnvironment>();
            firebase = provider.GetService<IFireBase>();
        }
    }  
}