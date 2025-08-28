using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace wholesale_retail_store.Infrastructure.Persistence;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        //This is to create a new db 
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=WholesaleRetailDB;User Id=sa;Password=Dev@2025!;TrustServerCertificate=True;");
        return new AppDbContext(optionsBuilder.Options);
    }
}