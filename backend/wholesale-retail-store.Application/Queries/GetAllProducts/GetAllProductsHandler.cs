using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using wholesale_retail_store.Application.Interface;
using wholesale_retail_store.Application.Models;
using wholesale_retail_store.Application.Queries;

namespace wholesale_retail_store.Application.Handlers;

public class GetAllProductsHandler : IRequestHandler<GetAllProductQuery, IEnumerable<ProductModel>>
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetAllProductsHandler> _logger;
    
    public GetAllProductsHandler(IProductRepository repository,
        IMapper mapper,
        ILogger<GetAllProductsHandler> logger)
    {
        _repository = repository;
        _mapper = mapper;
        _logger = logger;
    }
    public async Task<IEnumerable<ProductModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Getting all products");
        var response = await _repository.GetAllProductsAsync();
        var result = _mapper.Map<IEnumerable<ProductModel>>(response);
        _logger.LogInformation("Returning all products {result}", result);
        return result;
    }
}