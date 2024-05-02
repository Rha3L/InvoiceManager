using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Company;
using backend.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace backend.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public CompaniesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //Create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {
            var newCompany = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompanyById), new { id = newCompany.ID }, newCompany);
        }

        //Read
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanies()
        {
            var companies = await _context.Companies.ToListAsync();
            var convertedCompanies = _mapper.Map<CompanyDto>(companies);

            return Ok(convertedCompanies);
        }

        //Get a company by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanyById([FromRoute] int id)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(x => x.ID == id);

            if (company == null)
            {
                return NotFound();
            }

            var convertedCompany = _mapper.Map<CompanyDto>(company);

            return Ok(convertedCompany);
        }


        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany([FromRoute] int id, [FromBody] CompanyUpdateDto dto)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(x => x.ID == id);

            if (company == null)
            {
                return NotFound();
            }

            _context.Entry(dto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            var convertedCompany = _mapper.Map<CompanyUpdateDto>(company);

            return Ok(convertedCompany);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany([FromRoute] int id)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(x => x.ID == id);

            if (company == null)
            {
                return NotFound();
            }

            _context.Companies.Remove(company);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    } 
}

    