using AutoMapper;
using backend.Context;
using backend.Persistence.Dtos.Job;
using backend.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly IMapper _mapper;

        public JobsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //Create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDto dto)
        {
            var newJob = _mapper.Map<Job>(dto);
            await _context.Jobs.AddAsync(newJob);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetJobById), new { id = newJob.ID }, newJob);
        }

        //Read
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobDto>>> GetJobs()
        {
            var jobs = await _context.Jobs.Include(job => job.Company).ToListAsync();
            var convertedJobs = _mapper.Map<IEnumerable<JobDto>>(jobs);

            return Ok(convertedJobs);
        }

        //Get a job by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<JobDto>>> GetJobById([FromRoute] int id)
        {
            var job = await _context.Jobs.FirstOrDefaultAsync(x => x.ID == id);

            if (job == null)
            {
                return NotFound();
            }

            var convertedJob = _mapper.Map<JobDto>(job);

            return Ok(convertedJob);
        }

        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob([FromRoute] int id, [FromBody] JobUpdateDto dto)
        {
            var job = await _context.Jobs.FirstOrDefaultAsync(x => x.ID == id);

            if (job == null)
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

            var convertedJob = _mapper.Map<JobUpdateDto>(job);

            return Ok(convertedJob);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob([FromRoute] int id)
        {
            var job = await _context.Jobs.FirstOrDefaultAsync(x => x.ID == id);

            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
