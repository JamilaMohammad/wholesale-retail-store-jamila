namespace wholesale_retail_store.Infrastructure.Persistence.Entities;

public class Orders
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime CreatedAt { get; set; }
}