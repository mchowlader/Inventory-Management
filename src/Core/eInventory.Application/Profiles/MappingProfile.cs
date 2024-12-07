using AutoMapper;
using eInventory.Application.DTOs.Category;
using eInventory.Application.DTOs.Product;
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
