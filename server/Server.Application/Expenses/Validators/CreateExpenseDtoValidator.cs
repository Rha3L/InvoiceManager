using FluentValidation;
using Server.Application.Expenses.Dtos;

namespace Server.Application.Expenses.Validators;

public class CreateExpenseDtoValidator: AbstractValidator<CreateExpenseDto>
{
    public CreateExpenseDtoValidator() 
    {
        RuleFor(dto => dto.Categories)
            .IsInEnum()
            .WithMessage("Invalid category. Please choose from the valid categories.S");
    }
}
