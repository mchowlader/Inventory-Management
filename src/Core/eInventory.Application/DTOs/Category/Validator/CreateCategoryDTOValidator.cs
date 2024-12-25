using FluentValidation;

namespace eInventory.Application.DTOs.Category.Validator;

public class CreateCategoryDTOValidator : AbstractValidator<CreateCategoryDTO>
{
    public CreateCategoryDTOValidator()
    {
        Include(new ICategoryDTOValidator()); 
    }
}
