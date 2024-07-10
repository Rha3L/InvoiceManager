using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Server.Application.Customers.Dtos;
using Server.Domain.Repositories;

namespace Server.Application.Customers.Queries.GetAllCustomers;

public class GetAllCustomersQueryHandler(ILogger<GetAllCustomersQueryHandler> logger, IMapper mapper, ICustomerRepository customerRepository) : IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerDto>>
{
    public async Task<IEnumerable<CustomerDto>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Getting all customers");
        var customers = await customerRepository.GetAllAsync();
        var convertedCustomers = mapper.Map<IEnumerable<CustomerDto>>(customers);
        return convertedCustomers;
    }
}
