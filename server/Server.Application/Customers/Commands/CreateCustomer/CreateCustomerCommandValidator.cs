using FluentValidation;
using Server.Application.Customers.Dtos;

namespace Server.Application.Customers.Commands.CreateCustomer;

internal class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(dto => dto.Name)
            .NotEmpty()
            .WithMessage("Name is required.");

        RuleFor(dto => dto.ABN)
            .Length(11)
            .WithMessage("Please provide a valid ABN.");
    }
}
