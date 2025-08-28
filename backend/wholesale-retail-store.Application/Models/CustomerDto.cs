namespace wholesale_retail_store.Application.Models;

public class CustomerDto
{
    public Guid Id { get; set; }
    public string Data { get; set; }
    public string Name { get; set; }
    public bool IsRetailer { get; set; }
    public DateTime Created { get; set; }
}