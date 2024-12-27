using eInventory.Application.Common;
using eInventory.Application.DTOs.Product;
using eInventory.Application.Response;
using MediatR;

namespace eInventory.Application.Features.Products.Request.Commands;

public class CreateProductCommand : IRequest<Result<long>>
{
    public required CreateProductDTO ProductDTO { get; set; }
}
