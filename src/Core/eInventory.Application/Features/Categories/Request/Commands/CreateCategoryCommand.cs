using eInventory.Application.DTOs.Category;
using MediatR;

namespace eInventory.Application.Features.Categories.Request.Commands;

public class CreateCategoryCommand : IRequest<long>
{
    public required CreateCategoryDTO CategoryDTO { get; set; }
}
