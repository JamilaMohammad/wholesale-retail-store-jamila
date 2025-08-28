using MediatR;
using Microsoft.AspNetCore.Mvc;
using wholesale_retail_store.Application.Commands.CreateCustomer;
using wholesale_retail_store.Application.Models;
using wholesale_retail_store.Application.Queries.GetCustomerById;
using wholesale_retail_store.Domain.Entities;

namespace wholesale_retail_store.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<CustomerController> _logger;
    public CustomerController(IMediator mediator, ILogger<CustomerController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomerByIdAsync(Guid id)
    {
        _logger.BeginScope("CustomerId: {id}", id);
        var customer = await _mediator.Send(new GetCustomerByIdQuery{Id = id});
        if (customer == null)
        {
            return NotFound($"Customer not found for id {id}");
        }
        return Ok(customer);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCustomerAsync([FromBody] CustomerDto Customer)
    {
        var response = await _mediator.Send(new CreateCustomerCommand
        {
            Customer = Customer
        });
        return Ok(response);
    }
}