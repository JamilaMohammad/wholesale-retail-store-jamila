using Microsoft.AspNetCore.Mvc;

namespace wholesale_retail_store.API.Controllers;


[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Testing the controllers");
    }
}