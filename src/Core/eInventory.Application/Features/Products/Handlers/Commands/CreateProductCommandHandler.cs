using AutoMapper;
using eInventory.Application.DTOs.Product.Validator;
using eInventory.Application.Exceptions;
using eInventory.Application.Features.Products.Request.Commands;
using eInventory.Application.Persistence.Contracts;
using eInventory.Domain.Entities;
using MediatR;

namespace eInventory.Application.Features.Products.Handlers.Commands;

public class CreateProductCommandHandler(IProductRepository repository, IMapper mapper)
    : IRequestHandler<CreateProductCommand, long>
{
    public IProductRepository _repository { get; } = repository;
    public IMapper _mapper { get; } = mapper;

    public async Task<long> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateProductDTOValidator(_repository);
        var validationResult = await validator
            .ValidateAsync(request.ProductDTO, cancellationToken)
            .ConfigureAwait(false);

        if (validationResult.IsValid == false) 
            throw new ValidationException(validationResult);

        var product = _mapper.Map<Product>(request.ProductDTO);
        product = await _repository
            .AddAsync(product, cancellationToken)
            .ConfigureAwait(false);

        return product.Id;
    }
}
