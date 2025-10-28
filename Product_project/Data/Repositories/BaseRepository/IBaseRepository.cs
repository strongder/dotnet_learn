using AutoMapper;

namespace Product_project.Data.Repositories.BaseRepository
{
    public interface IBaseRepository<TEntity, Tkey> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(Tkey id);
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        Task<int> SaveAsync();
    }
}
