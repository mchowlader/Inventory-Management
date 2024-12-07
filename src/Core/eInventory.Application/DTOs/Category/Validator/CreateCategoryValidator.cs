using FluentValidation;

namespace eInventory.Application.DTOs.Category.Validator;

public class CreateCategoryValidator : AbstractValidator<CreateCategoryDTO>
{
    public CreateCategoryValidator()
    {
        RuleFor(v => v.Name)
             .NotEmpty().WithMessage("{PropertyName} is required.")
             .NotNull()
             .MaximumLength(20).WithMessage("{PropertyName} must not exceed 30 character.");

    }
}
