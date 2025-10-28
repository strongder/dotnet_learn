using AutoMapper;
using Product_project.Data.Repositories.BaseRepository;
using Product_project.Data.Repositories.ProductRepository;
using Product_project.DTOs;
using Product_project.models;
using Product_project.Services.BaseService;


namespace Product_project.Services.ProductService
{
    public class ProductService : BaseService<Product, int, ProductDto, ProductCreateDto>, IProductService
    {
        public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

