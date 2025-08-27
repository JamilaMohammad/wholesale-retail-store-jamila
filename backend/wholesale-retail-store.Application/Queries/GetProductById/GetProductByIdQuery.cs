using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Queries.GetProductById;

public class GetProductByIdQuery : IRequest<ProductModel>
{
    public int Id { get; set; }
}