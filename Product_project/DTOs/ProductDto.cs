namespace Product_project.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ProductGroupId { get; set; }
        public string CreateDate { get; set; } = string.Empty;
    }
}
