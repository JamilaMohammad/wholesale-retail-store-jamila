using Microsoft.EntityFrameworkCore;
namespace wholesale_retail_store.Infrastructure.Persistence;

public class ProductDbContext : DbContext
{

    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
        
    }
    
}