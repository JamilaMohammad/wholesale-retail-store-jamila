using MediatR;
using Microsoft.EntityFrameworkCore;
using wholesale_retail_store.Domain.Entities;
using wholesale_retail_store.Domain.Interface;
using wholesale_retail_store.Infrastructure.Persistence;

namespace wholesale_retail_store.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        var response = await _context.Products.ToListAsync();
        return response;
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        var response = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);
        return response;
    }

    public async Task AddProductsAsync(IEnumerable<Product> products)
    {
        await _context.Products.AddRangeAsync(products);
        await _context.SaveChangesAsync();
    }
    
}