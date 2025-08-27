using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Interface;

public interface IProductService
{
    public Task<IEnumerable<ProductModel>> GetAllProducts();
}