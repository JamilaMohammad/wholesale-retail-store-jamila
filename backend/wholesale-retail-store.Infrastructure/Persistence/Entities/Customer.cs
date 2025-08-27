namespace wholesale_retail_store.Infrastructure.Persistence.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
}