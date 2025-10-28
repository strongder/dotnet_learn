using Product_project.DTOs;
using Product_project.models;
using Product_project.Services.BaseService;

namespace Product_project.Services.ProductService
{
    public interface IProductService : IBaseService<Product, int, ProductDto, ProductCreateDto>
    {
    }
}
