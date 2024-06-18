using Microsoft.EntityFrameworkCore;

using backend.Infrastructure.Persistence;
using backend.Domain.Entities;
using backend.Interfaces;
using backend.Persistence.Dtos.Company;


namespace backend.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Customer> CreateAsync(Customer companyEntity)
        {
            await _context.Companies.AddAsync(companyEntity);
            await _context.SaveChangesAsync();
            return companyEntity;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
           return await _context.Companies.ToListAsync();
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            return await _context.Companies.Include(c => c.Jobs).FirstOrDefaultAsync(i => i.ID == id);
        }

        public async Task<Customer?> UpdateAsync(int id, CustomerUpdateDto companyDto)
        {
            var existingCompany = await _context.Companies.FirstOrDefaultAsync(i => i.ID == id);
            
            if (existingCompany != null)
            {
                return null;
            }

            _context.Entry(companyDto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return existingCompany;
        }

        public async Task<Customer?> DeleteAsync(int id)
        {
            var company = await _context.Companies.FirstOrDefaultAsync(i => i.ID == id);

            if(company == null)
            {
                return null;
            }

            _context.Companies.Remove(company);
            await _context.SaveChangesAsync();
            return company;
        }
    }
}
