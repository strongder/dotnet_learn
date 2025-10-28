using Product_project.DTOs;
using Product_project.models;
using Product_project.Services.BaseService;

namespace Product_project.Services.ProductGroupService
{
    public interface IProductGroupService : IBaseService<ProductGroup, int, ProductGroupDto, ProductGroupCreateDto>
    {
    }
}
