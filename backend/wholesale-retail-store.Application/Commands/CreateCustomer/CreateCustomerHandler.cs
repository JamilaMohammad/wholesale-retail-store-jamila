using MediatR;
using wholesale_retail_store.Application.Models;
using wholesale_retail_store.Domain.Entities;
using wholesale_retail_store.Domain.Interface;

namespace wholesale_retail_store.Application.Commands.CreateCustomer;

public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Unit>
{
    public readonly ICustomerRepository _repository;
    public CreateCustomerHandler(ICustomerRepository repository)
    {
        _repository = repository;
    }
    public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var model = new Customer
        {
            Name = request.Customer.Name,
            Data = request.Customer.Data,
            Id = request.Customer.Id,
            IsRetailer = request.Customer.IsRetailer,
        };
        await _repository.CreateCustomerAsync(model);
        return Unit.Value;
    }
}