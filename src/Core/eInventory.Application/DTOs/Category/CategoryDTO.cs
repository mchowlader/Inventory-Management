using eInventory.Application.DTOs.Common;

namespace eInventory.Application.DTOs.Category;

public class CategoryDTO : BaseDTO, ICategoryDTO
{
    public required string Name { get; set; } 
}
