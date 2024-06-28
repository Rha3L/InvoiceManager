using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Application.Customers;

namespace Server.API.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController(ICustomerService customerService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        { 
            var customers = await customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] int id)
        {
            var customer = await customerService.GetCustomerById(id);
            if (customer == null)
                return NotFound();

            return Ok(customer);
        }
    }
}
