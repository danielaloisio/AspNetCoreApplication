using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreApplication.Api.Configuration
{
    public static class ServiceRepositoryCollectionExtensions
    {
        public static IServiceCollection RegisterRepositoryServices(
           this IServiceCollection services)
        {
            //Add service and repositories

            return services;
        }
    }
}
