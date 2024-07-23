using MediatR;
using Server.Application.Suppliers.Dtos;

namespace Server.Application.Suppliers.Queries.GetSupplierById;

public class GetSupplierByIdQuery(int id) : IRequest<SupplierDto?>
{
    public int ID { get; } = id;
}
