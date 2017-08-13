using AspNetCoreApplication.Repository;
using AspNetCoreApplication.Service.Product;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreApplication.Api.Configuration
{
    public static class ServiceRepositoryCollectionExtensions
    {
        public static IServiceCollection RegisterRepositoryServices(
           this IServiceCollection services)
        {
            //Add service and repositories
            services.AddTransient<IProductService, ProductService>();

            services.AddTransient<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
