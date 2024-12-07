using eInventory.Application.DTOs.Product;
using MediatR;

namespace eInventory.Application.Features.Products.Request.Queries;
public class GetProductDetailsQueries : IRequest<ProductDTO>
{
    public long Id { get; set; }
}
