using AutoMapper;
using eInventory.Application.DTOs.Category;
using eInventory.Application.Features.Categories.Request.Queries;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Categories.Handler.Queries;

public class GetCategoryListRequestHandler(IProductRepository productRepository, IMapper mapper) : IRequestHandler<GetCategoryListRequest, List<CategoryDTO>>
{
    public IProductRepository _ProductRepository { get; } = productRepository;
    public IMapper _Mapper { get; } = mapper;

    public async Task<List<CategoryDTO>> Handle(GetCategoryListRequest request, CancellationToken cancellationToken)
    {
        var categories = await _ProductRepository
            .GetAllAsync(cancellationToken)
            .ConfigureAwait(false);

        return _Mapper.Map<List<CategoryDTO>>(categories);
    }
}
