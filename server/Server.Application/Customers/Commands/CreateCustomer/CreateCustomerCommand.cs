﻿using MediatR;

namespace Server.Application.Customers.Commands.CreateCustomer;

public class CreateCustomerCommand: IRequest<int>
{
    public string Name { get; set; } = string.Empty;
    public string? ABN { get; set; }
}
