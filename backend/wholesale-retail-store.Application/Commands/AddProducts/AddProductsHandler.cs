using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using wholesale_retail_store.Domain.Entities;
using wholesale_retail_store.Domain.Interface;

namespace wholesale_retail_store.Application.Commands.AddProducts;

public class AddProductsHandler : IRequestHandler<AddProductsCommand, IEnumerable<Product>>
{
    public readonly IProductRepository _repository;
    public readonly IMapper _mapper;
    public readonly ILogger<AddProductsHandler> _logger;
        
    public AddProductsHandler(IProductRepository repository,
        IMapper mapper,
        ILogger<AddProductsHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<IEnumerable<Product>> Handle(AddProductsCommand request, CancellationToken cancellationToken)
    {
        var model = _mapper.Map<IEnumerable<Product>>(request.ProductModel);
        var response = await _repository.AddProductsAsync(model);
        throw new NotImplementedException();
    }
}