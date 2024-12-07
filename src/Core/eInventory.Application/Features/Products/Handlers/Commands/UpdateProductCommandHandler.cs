using AutoMapper;
using eInventory.Application.Features.Products.Request.Commands;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Products.Handlers.Commands;

public class UpdateProductCommandHandler(IProductRepository repository, IMapper mapper)
    : IRequestHandler<UpdateProductCommand, Unit>
{
    public IProductRepository _repository { get; } = repository;
    public IMapper _mapper { get; } = mapper;

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = await _repository
            .GetAsync(request.Id, cancellationToken)
            .ConfigureAwait(false);
        _mapper.Map(request.ProductDTO, product);

        return Unit.Value;
    }
}
