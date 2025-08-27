using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Commands.CreateCustomer;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
{
    public Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        
        throw new NotImplementedException();
    }
}