using AutoMapper;
using Microsoft.Extensions.Logging;
using wholesale_retail_store.Application.Interface;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Services;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly IProductRepository _repository;
    private readonly ILogger<ProductService> _logger;
    
    public ProductService(IProductRepository repository, 
        IMapper mapper,
        ILogger<ProductService> logger)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }


    public async Task<IEnumerable<ProductModel>> GetAllProducts()
    {
        var response = await _repository.GetAllProductsAsync();
        _logger.LogInformation("Fetching all products");
        return _mapper.Map<IEnumerable<ProductModel>>(response);

    }
}