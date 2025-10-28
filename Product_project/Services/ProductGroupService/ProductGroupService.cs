

using AutoMapper;
using Product_project.Data.Repositories.ProductGroupRepository;
using Product_project.DTOs;
using Product_project.models;
using Product_project.Services.BaseService;

namespace Product_project.Services.ProductGroupService
{
    public class ProductGroupService : BaseService<ProductGroup, int, ProductGroupDto, ProductGroupCreateDto>, IProductGroupService
    {
        public ProductGroupService(IProductGroupRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}
