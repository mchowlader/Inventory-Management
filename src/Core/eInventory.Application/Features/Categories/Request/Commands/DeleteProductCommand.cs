using eInventory.Application.Common;
using MediatR;

namespace eInventory.Application.Features.Categories.Request.Commands;

public class DeleteProductCommand : IRequest<Result<Unit>>
{
    public long Id { get; set; }
}
