using eInventory.Application.Persistence.Contracts;
using FluentValidation;

namespace eInventory.Application.DTOs.Product.Validator;

public class IProductDTOValidator : AbstractValidator<IProductDTO>
{
    private readonly IProductRepository _repository;
    public IProductDTOValidator(IProductRepository repository)
    {
        _repository = repository;

        RuleFor(v => v.Name)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(20).WithMessage("{PropertyName} must not exceed {ComparisonValue} character.");

        RuleFor(v => v.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} character.");

        RuleFor(v => v.CreatedDate)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .LessThanOrEqualTo(DateTime.Now.Date).WithMessage("{PropertyName} cannot be a future date.");

        RuleFor(v => v.CategoryId)
            .GreaterThan(0)
            .MustAsync(async (id, token) =>
            {
                var categoryExits = await _repository.ExitsAsync(id, token);
                return !categoryExits;
            })
            .WithMessage("{PropertyName} does not exits.");
    }
}
