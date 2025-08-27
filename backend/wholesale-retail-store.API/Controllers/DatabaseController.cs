using Microsoft.AspNetCore.Mvc;
using wholesale_retail_store.Application.Interface;

namespace wholesale_retail_store.API.Controllers;

[ApiController]
[Route("controller")]
public class DatabaseController : ControllerBase
{
    private readonly IProductService _service;

    public DatabaseController(IProductService service)
    {
        _service = service;
    }
    [HttpGet]
    public string GetData()
    {
        _service.GetAllProducts();
        return string.Empty;
    }
}