using Server.Domain.Entities;

namespace Server.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer?> GetByIdAsync(int id);
        Task<int> CreateCustomer(Customer customerEntity);
        Task<Customer?> UpdateAsync(int id);
        Task<Customer?> DeleteAsync(int id);
    }
}
