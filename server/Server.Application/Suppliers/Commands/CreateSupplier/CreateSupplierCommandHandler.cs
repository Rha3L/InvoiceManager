using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Server.Domain.Entities;
using Server.Domain.Repositories;

namespace Server.Application.Suppliers.Commands.CreateSupplier;

internal class CreateSupplierCommandHandler(ILogger<CreateSupplierCommandHandler> logger, IMapper mapper, ISupplierRepository supplierRepository) : IRequestHandler<CreateSupplierCommand, int>
{
    public async Task<int> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Creating a new supplier");
        var supplier = mapper.Map<Supplier>(request);
        int id = await supplierRepository.CreateSupplier(supplier);
        return id;
    }
}
