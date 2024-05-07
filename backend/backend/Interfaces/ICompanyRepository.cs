using backend.Entities;
using backend.Persistence.Dtos.Company;

namespace backend.Interfaces
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllAsync();
        Task<Company?> GetByIdAsync(int id);
        Task<Company> CreateAsync(Company companyEntity);
        Task<Company?> UpdateAsync(int id, CompanyUpdateDto companyDto);
        Task<Company?> DeleteAsync(int id);
    }
}
