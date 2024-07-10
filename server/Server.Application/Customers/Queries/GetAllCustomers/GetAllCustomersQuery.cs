using MediatR;
using Server.Application.Customers.Dtos;

namespace Server.Application.Customers.Queries.GetAllCustomers;

public class GetAllCustomersQuery: IRequest<IEnumerable<CustomerDto>>
{
}
