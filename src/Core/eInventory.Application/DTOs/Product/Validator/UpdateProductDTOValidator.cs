using eInventory.Application.Persistence.Contracts;
using FluentValidation;

namespace eInventory.Application.DTOs.Product.Validator;

public class UpdateProductDTOValidator : AbstractValidator<UpdateProductDTO>
{
    private readonly IProductRepository _repository;
    public UpdateProductDTOValidator(IProductRepository repository)
    {
        _repository = repository;
        Include(new IProductDTOValidator(_repository));

        RuleFor(v => v.Id)
            .NotNull().WithMessage("{PropertyName} must be present");
    }
}
