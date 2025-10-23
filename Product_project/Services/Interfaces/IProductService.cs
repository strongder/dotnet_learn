using Product_project.DTOs;

namespace Product_project.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task<ProductDto> CreateAsync(ProductCreateDto dto);
        Task<bool> UpdateAsync(int id, ProductCreateDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
