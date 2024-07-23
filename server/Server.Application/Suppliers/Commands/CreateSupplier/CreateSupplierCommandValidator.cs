using FluentValidation;

namespace Server.Application.Suppliers.Commands.CreateSupplier;

public class CreateSupplierCommandValidator : AbstractValidator<CreateSupplierCommand
{
    public CreateSupplierCommandValidator()
    {
        RuleFor(dto => dto.Name)
            .NotEmpty()
            .WithMessage("Name is required.");

        RuleFor(dto => dto.ABN)
                .Length(11)
                .WithMessage("Please provide a valid ABN.");
    }
}
