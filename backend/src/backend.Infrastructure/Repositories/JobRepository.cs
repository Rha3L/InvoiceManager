using backend.Data.Context;
using backend.Domain.Entities;
using backend.Helpers;
using backend.Interfaces;
using backend.Persistence.Dtos.Job;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class JobRepository: IInvoiceRepository
    {
        private readonly ApplicationDbContext _context;
        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Income> CreateAsync(Income jobEntity)
        {
            await _context.Jobs.AddAsync(jobEntity);
            await _context.SaveChangesAsync();
            return jobEntity;
        }

        public async Task<Income?> DeleteAsync(int id)
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

        public Task<List<Income>> GetAllAsync(QueryObject query)
        {
            var jobs = _context.Jobs.AsQueryable();

            if(!DateTime.(query.ApplicationDate)
            {

            }
        }

        public async Task<Income?> GetByIdAsync(int id)
        {
            return await _context.Jobs.FirstOrDefaultAsync(i => i.ID == id);
        }

        public async Task<Income?> UpdateAsync(int id, InvoiceUpdateDto jobDto)
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
