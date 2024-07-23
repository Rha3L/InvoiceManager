using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Server.Application.Suppliers.Dtos;
using Server.Domain.Repositories;

namespace Server.Application.Suppliers.Queries.GetSupplierById;

public class GetSupplierByIdQueryHandler(ILogger<GetSupplierByIdQueryHandler> logger, IMapper mapper, ISupplierRepository supplierRepository) : IRequestHandler<GetSupplierByIdQuery, SupplierDto?>
{
    public async Task<SupplierDto?> Handle(GetSupplierByIdQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Getting supplier {request.ID}");
        var supplier = await supplierRepository.GetByIdAsync(request.ID);
        var convertedSupplier = mapper.Map<SupplierDto>(supplier);
        return convertedSupplier;
    }
}