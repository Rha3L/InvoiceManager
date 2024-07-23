using MediatR;
using Server.Application.Suppliers.Dtos;

namespace Server.Application.Suppliers.Queries.GetAllSuppliers;

public class GetAllSuppliersQuery : IRequest<IEnumerable<SupplierDto>>
{
}
