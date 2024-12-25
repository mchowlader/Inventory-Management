using eInventory.Application.DTOs.Category;
using MediatR;

namespace eInventory.Application.Features.Categories.Request.Commands;

public class UpdateCategoryCommand : IRequest<Unit>
{
    public long Id { get; set; }
    public required CategoryDTO CategoryDTO { get; set; }
}
