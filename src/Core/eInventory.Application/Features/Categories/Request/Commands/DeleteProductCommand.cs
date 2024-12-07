using MediatR;

namespace eInventory.Application.Features.Categories.Request.Commands;

public class DeleteProductCommand : IRequest
{
    public long Id { get; set; }
}
