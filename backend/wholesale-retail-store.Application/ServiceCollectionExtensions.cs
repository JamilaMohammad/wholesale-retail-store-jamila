using Microsoft.Extensions.DependencyInjection;
using wholesale_retail_store.Application.Services;
using wholesale_retail_store.Domain.Interface;

namespace wholesale_retail_store.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationExtensions(this IServiceCollection services)
    {
        
        services.AddScoped<IProductService, ProductService>();
       
        return services;
    }
}