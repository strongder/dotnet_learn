using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Product_project.Data.Repositories.BaseRepository;

namespace Product_project.Services.BaseService
{
    public class BaseService<TEntity, TKey, TDto, TCreateDto> : IBaseService<TEntity, TKey, TDto, TCreateDto>
        where TEntity : class
    {
        protected readonly IBaseRepository<TEntity, TKey> _repository;
        protected readonly IMapper _mapper;

        public BaseService(IBaseRepository<TEntity, TKey> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto?> GetByIdAsync(TKey id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity == null ? default : _mapper.Map<TDto>(entity);
        }

        public async Task<TDto> CreateAsync(TCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveAsync();
            return _mapper.Map<TDto>(entity);
        }

        public async Task<bool> UpdateAsync(TKey id, TCreateDto dto)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return false;

            _mapper.Map(dto, entity);
            await _repository.SaveAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(TKey id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return false;

            _repository.Remove(entity);
            await _repository.SaveAsync();
            return true;
        }
    }
}
