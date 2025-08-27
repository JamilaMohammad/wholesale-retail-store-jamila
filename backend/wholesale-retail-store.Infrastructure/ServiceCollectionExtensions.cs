using Microsoft.Extensions.DependencyInjection;
using wholesale_retail_store.Application.Interface;
using wholesale_retail_store.Application.Services;
using wholesale_retail_store.Infrastructure.Persistence;

namespace wholesale_retail_store.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureExtensions(this IServiceCollection services)
    {
        
        services.AddScoped<IProductRepository, ProductRepository>();
       
        return services;
    }
}