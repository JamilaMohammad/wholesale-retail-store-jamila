using wholesale_retail_store.Domain.Entities;

namespace wholesale_retail_store.Domain.Interface;

public interface IProductRepository
{
    public Task<IEnumerable<Product>> GetAllProductsAsync();
    
    public Task<Product> GetProductByIdAsync(int id);
    public Task AddProductsAsync(IEnumerable<Product> products);
}