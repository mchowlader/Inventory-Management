using eInventory.Application.DTOs.Product;
using MediatR;

namespace eInventory.Application.Features.Products.Request.Commands;

public class CreateProductCommand : IRequest<long>
{
    public required CreateProductDTO ProductDTO { get; set; }
}
