using wholesale_retail_store.Domain.Entities;
using wholesale_retail_store.Domain.Interface;

namespace wholesale_retail_store.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return new List<Product>();
    }

    public Task<Product> GetProductByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> AddProductsAsync(IEnumerable<Product> products)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> AddProductsAsync()
    {
        throw new NotImplementedException();
    }
}