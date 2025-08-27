using Microsoft.Extensions.Logging;
using wholesale_retail_store.Application.Interface;

namespace wholesale_retail_store.Application.Services;

public class ProductService : IProductService
{
    private readonly ILogger<ProductService> _logger;
    private readonly IProductRepository _repository;
    
    public ProductService(
        IProductRepository repository, 
        ILogger<ProductService> logger)
    {
        _repository = repository;
        _logger = logger;
    }


    public void GetAllProducts()
    {
        _repository.GetAllProducts();
        _logger.LogInformation("Fetching all products");
    }
}