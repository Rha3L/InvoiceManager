using Server.Domain.Entities;
using Server.Application.Customers.Dtos;

namespace Server.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task<Customer> CreateAsync(Customer customerEntity);
        Task<Customer?> UpdateAsync(int id, CustomerUpdateDto customerDto);
        Task<Customer?> DeleteAsync(int id);
    }
}
