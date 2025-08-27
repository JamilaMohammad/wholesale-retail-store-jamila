using wholesale_retail_store.Application.Interface;

namespace wholesale_retail_store.Infrastructure;

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