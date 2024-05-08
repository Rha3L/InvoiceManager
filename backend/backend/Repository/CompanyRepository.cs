using Microsoft.EntityFrameworkCore;

using backend.Context;
using backend.Entities;
using backend.Interfaces;
using backend.Persistence.Dtos.Company;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace backend.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<Company> CreateAsync(Company companyEntity)
        {
            await _context.Companies.AddAsync(companyEntity);
            await _context.SaveChangesAsync();
            return companyEntity;
        }

        public async Task<List<Company>> GetAllAsync()
        {
           return await _context.Companies.ToListAsync();
        }

        public async Task<Company?> GetByIdAsync(int id)
        {
            return await _context.Companies.Include(c => c.Jobs).FirstOrDefaultAsync(i => i.ID == id);
        }

        public async Task<Company?> UpdateAsync(int id, CompanyUpdateDto companyDto)
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

        public async Task<Company?> DeleteAsync(int id)
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
