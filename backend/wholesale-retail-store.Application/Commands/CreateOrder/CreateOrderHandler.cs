using MediatR;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Commands.CreateOrder;

public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, OrderModel>
{
    public CreateOrderHandler()
    {
        
    }


    public Task<OrderModel> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}