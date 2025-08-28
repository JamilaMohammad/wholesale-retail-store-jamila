using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Queries.GetAllProducts;

public class GetAllProductQuery : IRequest<IEnumerable<ProductModel>>
{
}