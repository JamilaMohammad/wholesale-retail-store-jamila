using Microsoft.EntityFrameworkCore;
using wholesale_retail_store.Domain.Entities;

namespace wholesale_retail_store.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Payment> Payments { get; set; }
}