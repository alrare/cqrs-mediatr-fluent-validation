using CqrsMediatRFluentValidation.Commands;
using FluentValidation;

namespace CqrsMediatRFluentValidation.Validators;

public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
{
    public AddProductCommandValidator()
    {
        RuleFor(p => p.Product.Name)
            .NotEmpty()
            .WithMessage("The name of the product can't be empty");

        RuleFor(p => p.Product.Name)
            .MaximumLength(60)
            .WithMessage("The length of the name can't be more than 60 characters long");
    }
}
