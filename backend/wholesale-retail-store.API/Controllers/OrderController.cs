using MediatR;
using Microsoft.AspNetCore.Mvc;
using wholesale_retail_store.Application.Commands.CreateOrder;

namespace wholesale_retail_store.API.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;
    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrder()
    {
        var order = await _mediator.Send(new CreateOrderCommand()
        {

        });
        return Ok(order);
    }
    [HttpPost]
    public async Task<IActionResult> CreateOrder()
    {
        var order = await _mediator.Send(new CreateOrderCommand());
        return Ok(order);
    }
}