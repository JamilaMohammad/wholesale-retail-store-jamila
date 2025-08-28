using MediatR;
using wholesale_retail_store.Application.Models;
using wholesale_retail_store.Domain.Entities;

namespace wholesale_retail_store.Application.Commands.AddProducts;

public class AddProductsCommand : IRequest<IEnumerable<Product>>
{
    public IEnumerable<ProductModel> ProductModel { get; set; }
}