using Microsoft.EntityFrameworkCore;
using Product_project.Data.Repositories.BaseRepository;
using Product_project.models;

namespace Product_project.Data.Repositories.ProductRepository
{
    public class ProductRepository : BaseRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
