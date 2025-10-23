using AutoMapper;
using Product_project.DTOs;
using Product_project.models;

namespace ProductApi.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductGroupCreateDto, ProductGroup>();
            CreateMap<ProductGroup, ProductGroupDto>();

        }
    }
}
