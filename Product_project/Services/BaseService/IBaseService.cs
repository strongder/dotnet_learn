namespace Product_project.Services.BaseService
{
    public interface IBaseService<TEntity, TKey, TDto, TCreateDto>
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto?> GetByIdAsync(TKey id);
        Task<TDto> CreateAsync(TCreateDto dto);
        Task<bool> UpdateAsync(TKey id, TCreateDto dto);
        Task<bool> DeleteAsync(TKey id);
    }
}
