using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Server.Domain.Entities;
using Server.Domain.Repositories;

namespace Server.Application.Customers.Commands.CreateCustomer;

public class CreateCustomerCommandHandler(ILogger<CreateCustomerCommandHandler> logger, IMapper mapper, ICustomerRepository customerRepository) : IRequestHandler<CreateCustomerCommand, int>
{
    public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Creating a new customer");
        var customer = mapper.Map<Customer>(request);
        int id = await customerRepository.CreateCustomer(customer);
        return id;
    }
}
