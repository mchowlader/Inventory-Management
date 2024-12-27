using AutoMapper;
using eInventory.Application.Common;
using eInventory.Application.DTOs.Product.Validator;
using eInventory.Application.Exceptions;
using eInventory.Application.Features.Products.Request.Commands;
using eInventory.Application.Persistence.Contracts;
using eInventory.Application.Response;
using eInventory.Domain.Entities;
using MediatR;

namespace eInventory.Application.Features.Products.Handlers.Commands;

public class CreateProductCommandHandler(IProductRepository repository, IMapper mapper)
    : IRequestHandler<CreateProductCommand, Result<long>> 
{
    public IProductRepository _repository { get; } = repository;
    public IMapper _mapper { get; } = mapper;

    public async Task<Result<long>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var validator = new CreateProductDTOValidator(_repository);
        var validationResult = await validator
            .ValidateAsync(request.ProductDTO, cancellationToken)
            .ConfigureAwait(false);

        if (validationResult.IsValid == false)
        {
            var error = validationResult.Errors
                .Select(e => e.ErrorMessage)
                .ToList();

            return Result<long>.Failure(error, "Creation Failed");
        }

        var product = _mapper.Map<Product>(request.ProductDTO);
        product = await _repository
            .AddAsync(product, cancellationToken)
            .ConfigureAwait(false);

        return Result<long>.Success(product.Id, "Creation Successfully");
    }
}
