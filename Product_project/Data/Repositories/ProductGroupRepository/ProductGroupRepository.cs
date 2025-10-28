using Microsoft.EntityFrameworkCore;
using Product_project.Data.Repositories.BaseRepository;
using Product_project.models;

namespace Product_project.Data.Repositories.ProductGroupRepository
{
    public class ProductGroupRepository : BaseRepository<ProductGroup, int>,IProductGroupRepository
    {
        public ProductGroupRepository(AppDbContext context) : base(context)
        {
        }
    }
}
