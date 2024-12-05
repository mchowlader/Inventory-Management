using AutoMapper;
using eInventory.Application.DTOs.ProductDTO;
using eInventory.Application.Features.Products.Request.Queries;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Products.Handlers.Queries;

public class GetProductListRequestHandler(IProductRepository productRepository, IMapper mapper) 
    : IRequestHandler<GetProductListRequest, List<ProductDTO>>
{
    private readonly IProductRepository _productRepository = productRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<List<ProductDTO>> Handle(GetProductListRequest request, CancellationToken cancellationToken)
    {
        var products = await _productRepository
            .GetAllAsync(cancellationToken)
            .ConfigureAwait(false);

        return _mapper.Map<List<ProductDTO>>(products);
    }
}
