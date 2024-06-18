using AutoMapper;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using backend.Interfaces;
using backend.Helpers;
using backend.Persistence.Dtos.Invoice;

namespace backend.Controllers
{
    [Route("api/invoices")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceRepository _jobRepo;

        private readonly IMapper _mapper;

        public InvoicesController(IMapper mapper, IInvoiceRepository jobRepo)
        {
            _jobRepo = jobRepo;
            _mapper = mapper;
        }

        //Create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateJob([FromBody] IncomeCreateDto dto)
        {
            // todo: upload invoice

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var newJob = _mapper.Map<Income>(dto);
            await _jobRepo.CreateAsync(newJob);

            return CreatedAtAction(nameof(GetJobById), new { id = newJob.ID }, newJob);
        }

        //Read
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IncomeDto>>> GetJobs([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var jobs = await _jobRepo.GetAllAsync();
            var convertedJobs = _mapper.Map<IEnumerable<IncomeDto>>(jobs);

            return Ok(convertedJobs);
        }

        //Get a job by ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<IncomeDto>>> GetJobById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var job = await _jobRepo.GetByIdAsync(id);
            var convertedJob = _mapper.Map<IncomeDto>(job);

            return Ok(convertedJob);
        }

        //Update
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateJob([FromRoute] int id, [FromBody] IncomeUpdateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var job = await _jobRepo.UpdateAsync(id, dto);
            var convertedJob = _mapper.Map<IncomeUpdateDto>(job);

            return Ok(convertedJob);
        }

        //Delete
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteJob([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var job = await _jobRepo.DeleteAsync(id);

            return NoContent();
        }
    }
}
