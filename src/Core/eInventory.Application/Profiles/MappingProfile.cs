using AutoMapper;
using eInventory.Application.DTOs;
using eInventory.Application.DTOs.ProductDTO;
using eInventory.Domain.Entities;

namespace eInventory.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Product, ProductDTO>().ReverseMap();
        CreateMap<Category, CategoryDTO>().ReverseMap();
    }
}
