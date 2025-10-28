using Product_project.Data.Repositories.BaseRepository;
using Product_project.models;


namespace Product_project.Data.Repositories.ProductRepository
{
    public interface IProductRepository : IBaseRepository<Product, int>
    {
        
    }
}
