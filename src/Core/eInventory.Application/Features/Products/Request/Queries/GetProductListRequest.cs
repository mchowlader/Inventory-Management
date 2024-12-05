using eInventory.Application.DTOs.ProductDTO;
using MediatR;

namespace eInventory.Application.Features.Products.Request.Queries;

public class GetProductListRequest : IRequest<List<ProductDTO>>
{
}
