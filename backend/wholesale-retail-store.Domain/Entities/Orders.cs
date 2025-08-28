namespace wholesale_retail_store.Domain.Entities;

public class Orders
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public string Data { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}