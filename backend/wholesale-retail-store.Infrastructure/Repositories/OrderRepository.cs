using wholesale_retail_store.Domain.Interface;

namespace wholesale_retail_store.Infrastructure.Repositories;

public class OrderRepository : IOrderRepository
{
    public Task CreateOrderAsync()
    {
        throw new NotImplementedException();
    }

    public Task GetOrderByIdAsync(int customerId)
    {
        throw new NotImplementedException();
    }
}