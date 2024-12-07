using eInventory.Application.DTOs.Category;
using MediatR;

namespace eInventory.Application.Features.Categories.Request.Queries;

public class GetCategoryListRequest : IRequest<List<CategoryDTO>>
{
}
