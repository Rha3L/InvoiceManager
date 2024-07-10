using MediatR;
using Server.Application.Customers.Dtos;

namespace Server.Application.Customers.Queries.GetCustomerById;

public class GetCustomerByIdQuery(int id) : IRequest<CustomerDto?>
{
    public int ID { get; } = id;
}
