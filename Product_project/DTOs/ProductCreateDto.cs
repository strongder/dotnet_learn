namespace Product_project.DTOs
{
    public class ProductCreateDto
    {
       
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ProductGroupId { get; set; }
    }
}

