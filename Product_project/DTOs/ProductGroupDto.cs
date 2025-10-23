namespace Product_project.DTOs
{
    public class ProductGroupDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string CreateDate { get; set; } = string.Empty;
    }
}
