using AutoMapper;
using eInventory.Application.Common;
using eInventory.Application.Features.Categories.Request.Commands;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Categories.Handler.Commands;

public class DeleteProductCommandHandler(IProductRepository repository, IMapper mapper)
    : IRequestHandler<DeleteProductCommand, Result<Unit>>
{
    public IProductRepository _repository { get; } = repository;
    public IMapper _mapper { get; } = mapper;

    public async Task<Result<Unit>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _repository
            .GetAsync(request.Id, cancellationToken)
            .ConfigureAwait(false);

        if (product is null)
        {
            var errors = new List<string>() { $"Product with ID {request.Id} was not found." };
            return Result<Unit>.Failure(errors, "Delete Failed");
        }

        await _repository
            .DeleteAsync(product, cancellationToken)
            .ConfigureAwait(false);

        return Result<Unit>.Success(Unit.Value, "Delete Successfully");
    }
}
