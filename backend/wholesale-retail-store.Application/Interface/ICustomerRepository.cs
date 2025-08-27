using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Application.Interface;

public interface ICustomerRepository
{
    public Task CreateCustomerAsync();
    public Task<CustomerDto> GetCustomerByIdAsync(Guid id);
    public Task UpdateCustomerAsync();
    public Task DeleteCustomerAsync();
}
