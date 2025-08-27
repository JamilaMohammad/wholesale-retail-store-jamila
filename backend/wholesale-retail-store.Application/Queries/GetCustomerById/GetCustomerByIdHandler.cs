using MediatR;
using wholesale_retail_store.Application.Interface;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Queries.GetCustomerById;

public class GetCustomerByIdHandler :IRequestHandler<GetCustomerByIdQuery, CustomerDto>
{
    public readonly ICustomerRepository _repository;
    public GetCustomerByIdHandler(ICustomerRepository repository)
    {
        _repository = repository;
    }
    public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        var response = await _repository.GetCustomerByIdAsync(request.Id);
        throw new NotImplementedException();
    }
}