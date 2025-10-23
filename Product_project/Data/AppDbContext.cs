using Microsoft.EntityFrameworkCore;
using Product_project.models;
using Product_project.Models;


namespace Product_project.Data
{
    public class AppDbContext : DbContext
    {
        private ServerVersion connectionString;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
     
    }
}
