using Microsoft.AspNetCore.Mvc;
using Product_project.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Product_project.DTOs;
using Product_project.models;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ProductGroupController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        
        public ProductGroupController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

    
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductGroupDto>>> GetProductGroups()
        {
            var productGroups = await _context.ProductGroups.ToArrayAsync();
            return Ok(_mapper.Map<IEnumerable<ProductGroupDto>>(productGroups));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductGroupDto>> GetById(int id)
        {
         
           var productGroup = await _context.ProductGroups.FindAsync(id);
            if (productGroup == null)
                return NotFound();
            return Ok(_mapper.Map<ProductGroupDto>(productGroup));
        }

        [HttpPost]
        public async Task<ActionResult<ProductGroupDto>> Create( ProductGroupCreateDto request)
        {
            var group =  _mapper.Map<ProductGroup>(request);
            _context.ProductGroups.Add(group);
            await _context.SaveChangesAsync();

            var result = _mapper.Map<ProductGroupDto>(group);
            return CreatedAtAction(nameof(GetById), new {id = group.Id}, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProductGroupCreateDto dto)
        {
            var group = await _context.ProductGroups.FindAsync(id);
            if (group == null)
                return NotFound();

            _mapper.Map(dto, group);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var group = await _context.ProductGroups.FindAsync(id);
            if (group == null)
                return NotFound();

            _context.ProductGroups.Remove(group);
            await _context.SaveChangesAsync();

            return NoContent();
        }


    }
}
