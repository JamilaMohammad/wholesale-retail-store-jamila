using wholesale_retail_store.Application.Interface;
using wholesale_retail_store.Application.Models;

namespace wholesale_retail_store.Infrastructure;

public class CustomerRepository : ICustomerRepository
{
    public Task CreateCustomerAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDto> GetCustomerByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCustomerAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteCustomerAsync()
    {
        throw new NotImplementedException();
    }
}