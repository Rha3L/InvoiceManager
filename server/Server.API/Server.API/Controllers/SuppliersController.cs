using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Application.Suppliers.Commands.CreateSupplier;
using Server.Application.Suppliers.Queries.GetAllSuppliers;
using Server.Application.Suppliers.Queries.GetSupplierById;


namespace Server.API.Controllers;

[Route("api/companies")]
[ApiController]
public class SuppliersController(IMediator mediator) : ControllerBase
{ 
    //Create
    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateSupplier([FromBody] CreateSupplierCommand command)
    {
        int id = await mediator.Send(command);

        return CreatedAtAction(nameof(GetSupplierById), new { id }, null);
    }

    //Read
    [HttpGet]
    public async Task<ActionResult> GetAllSuppliers()
    {
        var suppliers = await mediator.Send(new GetAllSuppliersQuery());

        return Ok(suppliers);
    }

    //Get a supplier by ID
    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetSupplierById([FromRoute] int id)
    {
        var supplier = await mediator.Send(new GetSupplierByIdQuery(id));

        return Ok(supplier);
    }


    //Update
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateCompany([FromRoute] int id, [FromBody] CustomerUpdateDto dto)
    {
        var company = await _companyRepo.UpdateAsync(id, dto);

        var convertedCompany = _mapper.Map<CustomerUpdateDto>(company);

        return Ok(convertedCompany);
    }

    //Delete
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteCompany([FromRoute] int id)
    {
        var company = await _companyRepo.DeleteAsync(id);

        return NoContent();
    }
} 

