using eInventory.Application.DTOs.Product;
using MediatR;

namespace eInventory.Application.Features.Products.Request.Queries;

public class GetProductListQueries : IRequest<List<ProductDTO>>
{
}
