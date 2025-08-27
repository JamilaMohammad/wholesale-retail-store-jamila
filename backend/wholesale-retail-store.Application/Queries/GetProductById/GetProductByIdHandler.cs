using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using wholesale_retail_store.Application.Interface;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Queries.GetProductById;

public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ProductModel>
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetProductByIdHandler> _logger;
    
    public GetProductByIdHandler(
        IProductRepository repository, IMapper mapper, ILogger<GetProductByIdHandler> logger)
    {
        _repository = repository;   
        _mapper = mapper;
        _logger = logger;
        
    }
    public async Task<ProductModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await _repository.GetProductByIdAsync(request.Id);
        var result = _mapper.Map<ProductModel>(response);
        _logger.LogInformation("GetProductByIdHandler: GetProductById called {id}", request.Id);
        return result;
    }
}