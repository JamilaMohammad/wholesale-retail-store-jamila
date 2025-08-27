namespace wholesale_retail_store.Application.Models;

public class OrderModel
{
    public Guid Id { get; set; }
    public IEnumerable<ProductModel> Products { get; set; }
}