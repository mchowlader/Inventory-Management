using AutoMapper;
using eInventory.Application.Features.Categories.Request.Commands;
using eInventory.Application.Persistence.Contracts;
using MediatR;

namespace eInventory.Application.Features.Categories.Handler.Commands;

public class UpdateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
    : IRequestHandler<UpdateCategoryCommand, Unit>
{
    public ICategoryRepository _repository { get; } = repository;
    public IMapper _mapper { get; } = mapper;

    public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _repository
           .GetAsync(request.Id, cancellationToken)
           .ConfigureAwait(false);
        _mapper.Map(request.CategoryDTO, category);

        return Unit.Value;
    }
}
