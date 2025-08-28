using wholesale_retail_store.Domain.Entities;

namespace wholesale_retail_store.Domain.Interface;

public interface IProductService
{
    public Task<IEnumerable<Product>> GetAllProducts();
}