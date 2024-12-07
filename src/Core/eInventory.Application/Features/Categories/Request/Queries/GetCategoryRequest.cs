using eInventory.Application.DTOs.Category;
using MediatR;

namespace eInventory.Application.Features.Categories.Request.Queries;

public class GetCategoryRequest : IRequest<CategoryDTO>
{
    public long Id { get; set; }
}
