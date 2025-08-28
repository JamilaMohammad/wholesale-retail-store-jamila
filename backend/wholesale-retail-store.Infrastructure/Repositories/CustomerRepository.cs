using wholesale_retail_store.Domain.Entities;
using wholesale_retail_store.Domain.Interface;
using wholesale_retail_store.Infrastructure.Persistence;

namespace wholesale_retail_store.Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly AppDbContext _context;
    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task CreateCustomerAsync(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();
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