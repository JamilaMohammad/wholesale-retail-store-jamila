using wholesale_retail_store.Application.Interface;

namespace wholesale_retail_store.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    
    public void GetAllProducts()
    {
        Console.WriteLine("COMPLETES");
    }
}