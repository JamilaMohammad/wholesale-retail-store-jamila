namespace wholesale_retail_store.Domain.Entities;

public class Cart
{
    public Guid CustomerId { get; set; }
    public int CartId { get; set; }
    public string Data { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
}