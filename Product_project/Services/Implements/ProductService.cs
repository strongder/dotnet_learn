using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Product_project.Data;
using Product_project.DTOs;
using Product_project.models;
using Product_project.Services.Interfaces;

namespace Product_project.Services.Implements
{
    public class ProductService : IProductService
    {

        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public ProductService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _context.Products.ToArrayAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return null;
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> CreateAsync(ProductCreateDto dto)
        {
            var product = _mapper.Map<Product>(dto);
            product.CreateDate = DateTime.UtcNow;
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<bool> UpdateAsync(int id, ProductCreateDto dto)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return false;

            _mapper.Map(dto, product); // map dữ liệu dto lên entity
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

