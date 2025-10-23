using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_project.models
{
    [Table("products")]   
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ProductGroupId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
