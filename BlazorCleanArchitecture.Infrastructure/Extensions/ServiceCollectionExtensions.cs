using BlazorCleanArchitecture.Application.IRepo;
using BlazorCleanArchitecture.Application.IServices;
using BlazorCleanArchitecture.Infrastructure.Repositories;
using BlazorCleanArchitecture.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCleanArchitecture.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration config, string connectionName)
        {
            string connectionString = config.GetConnectionString(connectionName);

            // ✅ Register ADO.NET-based ProductRepo
            services.AddScoped<IProductRepo>(provider => new ProductRepo(connectionString));

            // Register services
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
