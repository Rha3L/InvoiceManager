using backend.Context;
using backend.Entities;
using backend.Interfaces;
using backend.Persistence.Dtos.Company;
using backend.Persistence.Dtos.Job;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class JobRepository: IJobRepository
    {
        private readonly ApplicationDbContext _context;
        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Job> CreateAsync(Job jobEntity)
        {
            await _context.Jobs.AddAsync(jobEntity);
            await _context.SaveChangesAsync();
            return jobEntity;
        }

        public async Task<Job?> DeleteAsync(int id)
        {
            var job = await _context.Jobs.FirstOrDefaultAsync(i => i.ID == id);

            if (job == null)
            {
                return null;
            }

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<List<Job>> GetAllAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job?> GetByIdAsync(int id)
        {
            return await _context.Jobs.FirstOrDefaultAsync(i => i.ID == id);
        }

        public async Task<Job?> UpdateAsync(int id, JobUpdateDto jobDto)
        {
            var existingJob = await _context.Jobs.FirstOrDefaultAsync(i => i.ID == id);

            if (existingJob != null)
            {
                return null;
            }

            _context.Entry(jobDto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return existingJob;
        }
    }
}
