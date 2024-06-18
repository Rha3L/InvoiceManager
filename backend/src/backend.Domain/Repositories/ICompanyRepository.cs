using backend.Domain.Entities;
using backend.Persistence.Dtos.Company;

namespace backend.Interfaces
{
    public interface ICompanyRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task<Customer> CreateAsync(Customer companyEntity);
        Task<Customer?> UpdateAsync(int id, CustomerUpdateDto companyDto);
        Task<Customer?> DeleteAsync(int id);
    }
}
