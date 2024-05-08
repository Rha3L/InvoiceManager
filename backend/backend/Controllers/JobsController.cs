using AutoMapper;
using backend.Persistence.Dtos.Job;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using backend.Interfaces;

namespace backend.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobRepository _jobRepo;

        private readonly IMapper _mapper;

        public JobsController(IMapper mapper, IJobRepository jobRepo)
        {
            _jobRepo = jobRepo;
            _mapper = mapper;
        }

        //Create
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDto dto)
        {
            var newJob = _mapper.Map<Job>(dto);
            await _jobRepo.CreateAsync(newJob);

            return CreatedAtAction(nameof(GetJobById), new { id = newJob.ID }, newJob);
        }

        //Read
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobDto>>> GetJobs()
        {
            var jobs = await _jobRepo.GetAllAsync();
            var convertedJobs = _mapper.Map<IEnumerable<JobDto>>(jobs);

            return Ok(convertedJobs);
        }

        //Get a job by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<JobDto>>> GetJobById([FromRoute] int id)
        {
            var job = await _jobRepo.GetByIdAsync(id);
            var convertedJob = _mapper.Map<JobDto>(job);

            return Ok(convertedJob);
        }

        //Update
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob([FromRoute] int id, [FromBody] JobUpdateDto dto)
        {
            var job = await _jobRepo.UpdateAsync(id, dto);
            var convertedJob = _mapper.Map<JobUpdateDto>(job);

            return Ok(convertedJob);
        }

        //Delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob([FromRoute] int id)
        {
            var job = await _jobRepo.DeleteAsync(id);

            return NoContent();
        }
    }
}
