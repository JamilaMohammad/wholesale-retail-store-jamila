namespace wholesale_retail_store.Domain.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Data { get; set; }
    public bool IsRetailer { get; set;  }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}