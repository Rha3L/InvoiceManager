
using Microsoft.Extensions.Logging;
using Server.Domain.Entities;
using Server.Domain.Repositories;

namespace Server.Application.Customers
{
    internal class CustomerService(ICustomerRepository customerRepository, ILogger<CustomerService> logger) : ICustomerService
    {
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            logger.LogInformation("Getting all customers");
            var customers = await customerRepository.GetAllAsync();
            return customers;
        }

        public async Task<Customer?> GetCustomerById(int id)
        {
            logger.LogInformation($"Getting customer {id}");
            var customer = await customerRepository.GetByIdAsync(id);
            return customer;
    }
}
