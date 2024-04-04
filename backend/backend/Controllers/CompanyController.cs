using backend.Core.Context;
using backend.Core.Dtos.Company;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationDbContext _context { get; }

        public CompanyController (ApplicationDbContext context)
        {
            _context = context;
        }

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto) 
        {
        
        }

        //Read

        //Update

        //Delete
    }
}
