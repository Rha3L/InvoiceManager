using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Application.Customers.Commands.CreateCustomer;
using Server.Application.Customers.Queries.GetAllCustomers;
using Server.Application.Customers.Queries.GetCustomerById;


namespace Server.API.Controllers;

[Route("api/customers")]
[ApiController]
public class CustomersController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers = await mediator.Send(new GetAllCustomersQuery());
        return Ok(customers);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetCustomerById([FromRoute] int id)
    {
        var customer = await mediator.Send(new GetCustomerByIdQuery(id));
        
        if (customer == null)
            return NotFound();

        return Ok(customer);
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)
    {
        int id = await mediator.Send(command);

        return CreatedAtAction(nameof(GetCustomerById), new { id }, null);
    }
}
