using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Commands.CreateCustomer;

public class CreateCustomerCommand : IRequest<Unit>
{
    public CustomerDto Customer { get; set; }
    
}