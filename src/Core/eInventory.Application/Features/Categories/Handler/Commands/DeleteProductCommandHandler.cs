using AutoMapper;
using eInventory.Application.Features.Categories.Request.Commands;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Categories.Handler.Commands;

public class DeleteProductCommandHandler(IProductRepository repository, IMapper mapper)
    : IRequestHandler<DeleteProductCommand>
{
    public IProductRepository _repository { get; } = repository;
    public IMapper _mapper { get; } = mapper;

    public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _repository
            .GetAsync(request.Id, cancellationToken)
            .ConfigureAwait(false);

        await _repository
            .DeleteAsync(product, cancellationToken)
            .ConfigureAwait(false);
    }
}
