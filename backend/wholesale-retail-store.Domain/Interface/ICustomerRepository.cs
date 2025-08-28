using wholesale_retail_store.Domain.Entities;

namespace wholesale_retail_store.Domain.Interface;

public interface ICustomerRepository
{
    public Task CreateCustomerAsync(Customer customer);
    public Task<Customer> GetCustomerByIdAsync(Guid id);
    public Task UpdateCustomerAsync();
    public Task DeleteCustomerAsync();
}
