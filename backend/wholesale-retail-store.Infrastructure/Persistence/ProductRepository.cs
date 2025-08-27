using wholesale_retail_store.Application.Interface;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    
    public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
    {
        return new List<ProductModel>();
    }

    public Task<ProductModel> GetProductByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}