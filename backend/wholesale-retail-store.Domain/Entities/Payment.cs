namespace wholesale_retail_store.Domain.Entities;

public class Payment
{
    public Guid CustomerId { get; set; }
    public Guid PaymentId { get; set; }
    public string Data { get; set; }
    public DateTime CreatedAt { get; set; }
}