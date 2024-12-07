using eInventory.Application.DTOs.Category;
using MediatR;

namespace eInventory.Application.Features.Categories.Request.Commands;

public class CreateCategoryCommand : IRequest<long>
{
    public CreateCategoryDTO CategoryDTO { get; set; }
}
