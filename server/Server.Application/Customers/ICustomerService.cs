using Server.Domain.Entities;

namespace Server.Application.Customers
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer?> GetCustomerById(int id);
    }
}