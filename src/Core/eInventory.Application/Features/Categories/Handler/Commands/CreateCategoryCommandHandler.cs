using AutoMapper;
using eInventory.Application.DTOs.Category.Validator;
using eInventory.Application.Exceptions;
using eInventory.Application.Features.Categories.Request.Commands;
using eInventory.Application.Persistence.Contracts;
using eInventory.Domain.Entities;
using MediatR;

namespace eInventory.Application.Features.Categories.Handler.Commands;

public class CreateCategoryCommandHandler(ICategoryRepository repository, IMapper mapper)
    : IRequestHandler<CreateCategoryCommand, long>
{
    public ICategoryRepository _repository { get; } = repository;
    public IMapper _mapper { get; } = mapper;

    public async Task<long> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateCategoryDTOValidator();
        var validationResult = await validator.ValidateAsync(request.CategoryDTO, cancellationToken);

        if (validationResult.IsValid == false)
            throw new ValidationException(validationResult);

        var category = _mapper.Map<Category>(request.CategoryDTO);
        category = await _repository
            .AddAsync(category, cancellationToken)
            .ConfigureAwait(false);

        return category.Id;
    }
}
