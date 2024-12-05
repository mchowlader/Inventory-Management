using eInventory.Application.DTOs.ProductDTO;
using MediatR;

namespace eInventory.Application.Features.Products.Request.Queries;

public class GetProductDetailsRequest : IRequest<ProductDTO>
{
    public long Id { get; set; }
}
