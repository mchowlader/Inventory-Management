using eInventory.Application.DTOs.Common;

namespace eInventory.Application.DTOs.Category;

public class CreateCategoryDTO : BaseDTO, ICategoryDTO
{
    public required string Name { get; set; }
}
