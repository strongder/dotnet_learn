using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_project.models
{
    [Table("product_groups")]   
    public class ProductGroup
    {
        [Key]   
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
