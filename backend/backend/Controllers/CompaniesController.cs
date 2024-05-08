using AutoMapper;
using backend.Context;
using backend.Persistence.Dtos.Company;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Interfaces;


namespace backend.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    { 

        private readonly ICompanyRepository _companyRepo;

        private readonly IMapper _mapper;

        public CompaniesController(ApplicationDbContext context, IMapper mapper, ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
            
            _mapper = mapper;
        }

        //Create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {
            var newCompany = _mapper.Map<Company>(dto);
            await _companyRepo.CreateAsync(newCompany);

            return CreatedAtAction(nameof(GetCompanyById), new { id = newCompany.ID }, newCompany);
        }

        //Read
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanies()
        {
            var companies = await _companyRepo.GetAllAsync();
            var convertedCompanies = _mapper.Map<CompanyDto>(companies);

            return Ok(convertedCompanies);
        }

        //Get a company by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompanyById([FromRoute] int id)
        {
            var company = await _companyRepo.GetByIdAsync(id);

            var convertedCompany = _mapper.Map<CompanyDto>(company);

            return Ok(convertedCompany);
        }


        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompany([FromRoute] int id, [FromBody] CompanyUpdateDto dto)
        {
            var company = await _companyRepo.UpdateAsync(id, dto);

            var convertedCompany = _mapper.Map<CompanyUpdateDto>(company);

            return Ok(convertedCompany);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany([FromRoute] int id)
        {
            var company = await _companyRepo.DeleteAsync(id);

            return NoContent();
        }
    } 
}

    