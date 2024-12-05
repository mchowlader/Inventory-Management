using AutoMapper;
using eInventory.Application.DTOs;
using eInventory.Application.Features.Categories.Request.Queries;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Categories.Handler.Queries;

public class GetCategoryRequestHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<GetCategoryRequest, CategoryDTO>
{
    public IProductRepository _ProductRepository { get; } = productRepository;
    public IMapper _Mapper { get; } = mapper;

    public async Task<CategoryDTO> Handle(GetCategoryRequest request, CancellationToken cancellationToken)
    {
    
        var category = await _ProductRepository
            .GetAsync(request.Id, cancellationToken)
            .ConfigureAwait(false);

        return _Mapper.Map<CategoryDTO>(category); 
    }
}
