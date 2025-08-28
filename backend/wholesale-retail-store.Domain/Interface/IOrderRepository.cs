namespace wholesale_retail_store.Domain.Interface;

public interface IOrderRepository
{
    public Task CreateOrderAsync();
    
    public Task GetOrderByIdAsync(int customerId);
}