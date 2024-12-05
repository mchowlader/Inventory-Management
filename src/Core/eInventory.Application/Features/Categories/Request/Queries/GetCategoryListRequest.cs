using eInventory.Application.DTOs;
using MediatR;

namespace eInventory.Application.Features.Categories.Request.Queries;

public class GetCategoryListRequest : IRequest<List<CategoryDTO>>
{
}
