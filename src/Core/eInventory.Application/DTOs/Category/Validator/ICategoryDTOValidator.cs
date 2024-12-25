using FluentValidation;

namespace eInventory.Application.DTOs.Category.Validator;

public class ICategoryDTOValidator : AbstractValidator<ICategoryDTO>
{
    public ICategoryDTOValidator()
    {
        RuleFor(v => v.Name)
              .NotEmpty().WithMessage("{PropertyName} is required.")
              .NotNull()
              .MaximumLength(20).WithMessage("{PropertyName} must not exceed {ComparisonValue} character.");
    }
}
