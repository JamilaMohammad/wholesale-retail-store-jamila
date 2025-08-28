using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using wholesale_retail_store.Application.Services;
using wholesale_retail_store.Domain.Interface;
using wholesale_retail_store.Infrastructure.Persistence;
using wholesale_retail_store.Infrastructure.Repositories;

namespace wholesale_retail_store.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureExtensions(this IServiceCollection services)
    {
        
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IOrderRepository, OrderRepository>();

        return services;
    }
}