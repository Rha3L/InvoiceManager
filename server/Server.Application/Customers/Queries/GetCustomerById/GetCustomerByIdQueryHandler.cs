using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Server.Application.Customers.Dtos;
using Server.Domain.Repositories;

namespace Server.Application.Customers.Queries.GetCustomerById;

public class GetCustomerByIdQueryHandler(ILogger<GetCustomerByIdQueryHandler> logger, IMapper mapper, ICustomerRepository customerRepository) : IRequestHandler<GetCustomerByIdQuery, CustomerDto?>
{
    public async Task<CustomerDto?> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Getting customer {request.ID}");
        var customer = await customerRepository.GetByIdAsync(request.ID);
        var convertedCustomer = mapper.Map<CustomerDto>(customer);
        return convertedCustomer;
    }
}
