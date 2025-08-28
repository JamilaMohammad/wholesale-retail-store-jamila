namespace wholesale_retail_store.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
}