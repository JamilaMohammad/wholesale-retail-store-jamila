using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Commands.CreateCustomer;

public class CreateCustomerCommand : IRequest<CustomerDto>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
}