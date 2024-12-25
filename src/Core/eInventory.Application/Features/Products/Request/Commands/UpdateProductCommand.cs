using eInventory.Application.DTOs.Product;
using MediatR;

namespace eInventory.Application.Features.Products.Request.Commands;

public class UpdateProductCommand : IRequest<Unit>
{
    public long Id { get; set; }
    public required ProductDTO ProductDTO { get; set; }
}
