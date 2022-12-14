using System;
using Customizing_User_Data.Areas.Identity.Data;
using Customizing_User_Data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Customizing_User_Data.Areas.Identity.IdentityHostingStartup))]
namespace Customizing_User_Data.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Customizing_User_DataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Customizing_User_DataContextConnection")));

                services.AddDefaultIdentity<Customizing_User_DataUser>()
                    .AddEntityFrameworkStores<Customizing_User_DataContext>();
            });
        }
    }
}