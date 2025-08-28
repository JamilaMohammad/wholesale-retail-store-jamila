using wholesale_retail_store.Domain.Entities;
using wholesale_retail_store.Domain.Interface;

namespace wholesale_retail_store.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public Task CreateCustomerAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetCustomerByIdAsync(Guid id)
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