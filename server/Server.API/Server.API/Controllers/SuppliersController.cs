using AutoMapper;
using backend.Persistence.Dtos.Company;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using backend.Interfaces;


namespace Server.API.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class SuppliersController : ControllerBase
    { 

        private readonly ICompanyRepository _companyRepo;

        private readonly IMapper _mapper;

        public SuppliersController(IMapper mapper, ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
            
            _mapper = mapper;
        }

        //Create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCompany([FromBody] CustomerCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newCompany = _mapper.Map<Customer>(dto);
            await _companyRepo.CreateAsync(newCompany);

            return CreatedAtAction(nameof(GetCompanyById), new { id = newCompany.ID }, newCompany);
        }

        //Read
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCompanies()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var companies = await _companyRepo.GetAllAsync();
            var convertedCompanies = _mapper.Map<CustomerDto>(companies);

            return Ok(convertedCompanies);
        }

        //Get a company by ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCompanyById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var company = await _companyRepo.GetByIdAsync(id);

            var convertedCompany = _mapper.Map<CustomerDto>(company);

            return Ok(convertedCompany);
        }


        //Update
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCompany([FromRoute] int id, [FromBody] CustomerUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var company = await _companyRepo.UpdateAsync(id, dto);

            var convertedCompany = _mapper.Map<CustomerUpdateDto>(company);

            return Ok(convertedCompany);
        }

        //Delete
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteCompany([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var company = await _companyRepo.DeleteAsync(id);

            return NoContent();
        }
    } 
}

    