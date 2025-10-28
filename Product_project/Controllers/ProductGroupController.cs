using Microsoft.AspNetCore.Mvc;
using Product_project.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Product_project.DTOs;
using Product_project.models;
using Microsoft.AspNetCore.Authorization;
using Product_project.Services.ProductGroupService;

namespace ProductApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/product-groups")]
    public class ProductGroupController : ControllerBase
    {
        private readonly IProductGroupService _service;

        public ProductGroupController(IProductGroupService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductGroupDto>>> GetProductGroups()
        {
            var groups = await _service.GetAllAsync();
            return Ok(groups);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductGroupDto>> GetById(int id)
        {
            var group = await _service.GetByIdAsync(id);
            if (group == null) return NotFound();
            return Ok(group);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<ProductGroupDto>> Create(ProductGroupCreateDto dto)
        {
            var group = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = group.Id }, group);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProductGroupCreateDto dto)
        {
            var updated = await _service.UpdateAsync(id, dto);
            if (!updated) return NotFound();
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
