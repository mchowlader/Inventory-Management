using eInventory.Application.Persistence.Contracts;
using FluentValidation;

namespace eInventory.Application.DTOs.Product.Validator;

public class CreateProductDTOValidator : AbstractValidator<CreateProductDTO>
{
    private readonly IProductRepository _repository;
    public CreateProductDTOValidator(IProductRepository repository)
    {
        _repository = repository;
        Include(new IProductDTOValidator(_repository));
    }
}
