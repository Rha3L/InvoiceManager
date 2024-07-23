using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Server.Application.Suppliers.Dtos;
using Server.Domain.Repositories;

namespace Server.Application.Suppliers.Queries.GetAllSuppliers;

public class GetAllSuppliersQueryHandler(ILogger<GetAllSuppliersQueryHandler> logger, IMapper mapper, ISupplierRepository supplierRepository) : IRequestHandler<GetAllSuppliersQuery, IEnumerable<SupplierDto>>
{
    public async Task<IEnumerable<SupplierDto>> Handle(GetAllSuppliersQuery request, CancellationToken cancellationToken)
    {
        logger.LogInformation("Getting all suppliers");
        var suppliers = await supplierRepository.GetAllAsync();
        var convertedSuppliers = mapper.Map<IEnumerable<SupplierDto>>(suppliers);
        return convertedSuppliers;
    }
}
