using MediatR;
using Microsoft.AspNetCore.Mvc;
using wholesale_retail_store.Application.Commands.AddProducts;
using wholesale_retail_store.Application.Models;
using wholesale_retail_store.Application.Queries;
using wholesale_retail_store.Application.Queries.GetAllProducts;
using wholesale_retail_store.Application.Queries.GetProductById;

namespace wholesale_retail_store.API.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{
    public readonly IMediator _mediator;
    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _mediator.Send(new GetAllProductQuery())
            ?? throw new Exception("No products found");
        return Ok(products);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductByIdAsync(int id)
    {
        var product = await _mediator.Send(new GetProductByIdQuery());
        return Ok(product);
    }

    [HttpPost]
    public async Task<IActionResult> AddProducts([FromForm] IEnumerable<ProductModel> product)
    {
        var products = await _mediator.Send(new AddProductsCommand
        {
            ProductModel = product
        });
        
        return Ok(products);
    }
}