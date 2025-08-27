using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Interface;

public interface IProductRepository
{
    public Task<IEnumerable<ProductModel>> GetAllProductsAsync();
    
    public Task<ProductModel> GetProductByIdAsync(int id);
}