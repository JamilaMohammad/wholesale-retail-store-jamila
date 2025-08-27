using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Queries.GetCustomerById;

public class GetCustomerByIdQuery : IRequest<CustomerDto>
{
    public Guid Id { get; set; }
}