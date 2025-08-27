namespace wholesale_retail_store.Application.Interface;

public interface IOrderRepository
{
    public Task CreateOrderAsync();
    
    public Task GetOrderByIdAsync(int customerId);
}