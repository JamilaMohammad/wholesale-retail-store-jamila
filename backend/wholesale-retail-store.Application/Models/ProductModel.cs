namespace wholesale_retail_store.Application.Models;

public class ProductModel
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    
}