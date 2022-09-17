using Contracts;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Service;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Extension
{
    public static class ServiceExtension
    {
        public static void ConfigurationService(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManger, RepositoryManger>();
        }
        public static void ConfigurationRepository(this IServiceCollection services)
        {
            services.AddScoped<IServiceManger, ServiceManger>();

        }
        public static void ConfigurationSqlConnection(this IServiceCollection services, IConfiguration configuration) =>
               services.AddDbContext<RepoDbContext>(opts =>
               opts.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), b =>
                                               b.MigrationsAssembly("AddressBook")));

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<IdentityUser<int>>(o =>
            {
                o.Password.RequireDigit = true;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.User.RequireUniqueEmail = true;
            });

            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), builder.Services);
            builder.AddEntityFrameworkStores<RepoDbContext>().AddDefaultTokenProviders();
        }


    }
}
