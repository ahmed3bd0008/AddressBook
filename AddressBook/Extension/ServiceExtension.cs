using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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

        }
        public static void ConfigurationRepository(this IServiceCollection services)
        {

        }
        public static void ConfigurationSqlConnection(this IServiceCollection services,IConfiguration configuration )
        {

        }
    }
}
