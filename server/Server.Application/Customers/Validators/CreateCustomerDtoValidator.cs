using FluentValidation;
using Server.Application.Customers.Dtos;

namespace Server.Application.Customers.Validators;

internal class CreateCustomerDtoValidator: AbstractValidator<CreateCustomerDto>
{
    public CreateCustomerDtoValidator()
    {
        RuleFor(dto => dto.Name)
            .NotEmpty()
            .WithMessage("Name is required.");

        RuleFor(dto => dto.ABN)
            .Length(11)
            .WithMessage("Please provide a valid ABN.");
    }
}
