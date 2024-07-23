using MediatR;

namespace Server.Application.Suppliers.Commands.CreateSupplier;

public class CreateSupplierCommand : IRequest<int>
{
    public string Name { get; set; } = string.Empty;

    public string ABN { get; set; } = string.Empty;
}
