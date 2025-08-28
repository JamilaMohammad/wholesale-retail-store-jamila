using MediatR;
using Microsoft.Extensions.Logging;
using wholesale_retail_store.Domain.Entities;
using wholesale_retail_store.Domain.Interface;

namespace wholesale_retail_store.Application.Commands.AddProducts;

public class AddProductsHandler : IRequestHandler<AddProductsCommand, Unit>
{
    public readonly IProductRepository _repository;
    public readonly ILogger<AddProductsHandler> _logger;
        
    public AddProductsHandler(IProductRepository repository,
        ILogger<AddProductsHandler> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    public async Task<Unit> Handle(AddProductsCommand request, CancellationToken cancellationToken)
    {
        var model = request.ProductModel.Select(i => new Product()
            {
                Description = i.Description,
                Name = i.Name,
                Price = i.Price,
                Stock = i.Stock,
                ProductId = i.ProductId
            })
            .ToList();
        await _repository.AddProductsAsync(model);
        _logger.LogInformation("Added products into db");
        return Unit.Value;
    }
}