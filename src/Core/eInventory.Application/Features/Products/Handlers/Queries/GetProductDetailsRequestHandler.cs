using AutoMapper;
using eInventory.Application.DTOs.ProductDTO;
using eInventory.Application.Features.Products.Request.Queries;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Products.Handlers.Queries;

public class GetProductDetailsRequestHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<GetProductDetailsRequest, ProductDTO>
{
    public IProductRepository _productRepository { get; } = productRepository;
    public IMapper _mapper { get; } = mapper;

    public async Task<ProductDTO> Handle(GetProductDetailsRequest request, CancellationToken cancellationToken)
    {
        var Product = await _productRepository
            .GetAsync(request.Id, cancellationToken)
            .ConfigureAwait(false);

        return _mapper.Map<ProductDTO>(Product);
    }
}
