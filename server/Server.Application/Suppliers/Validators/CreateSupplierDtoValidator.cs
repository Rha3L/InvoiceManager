using FluentValidation;
using Server.Application.Suppliers.Dtos;

namespace Server.Application.Suppliers.Validators;

public class CreateSupplierDtoValidator : AbstractValidator<CreateSupplierDto
{
    public CreateSupplierDtoValidator()
    {
        RuleFor(dto => dto.Name)
            .NotEmpty()
            .WithMessage("Name is required.");

        RuleFor(dto => dto.ABN)
                .Length(11)
                .WithMessage("Please provide a valid ABN.");
    }
}
