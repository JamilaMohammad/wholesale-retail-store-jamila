using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Commands.AddProducts;

public class AddProductsCommand : IRequest<Unit>
{
    public IEnumerable<ProductModel> ProductModel { get; set; }
}