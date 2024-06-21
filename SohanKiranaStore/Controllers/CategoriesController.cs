using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SohanKiranaStore.Model.Models;
using SohanKiranaStore.Model.DTO;
using SohanKiranaStore.Repository.DBContect;
using System.Collections.Generic;
using System.Threading.Tasks;
using SohanKiranaStore.Core.Service;

namespace SohanKiranaStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IWebHostEnvironment _env;

        public CategoriesController(ICategoryService categoryService,IWebHostEnvironment env)
        {
            _categoryService = categoryService;
            _env = env;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
        {
            try
            {
                var categories = await _categoryService.GetCategoriesAsync();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            try
            {
                var category = await _categoryService.GetCategoryAsync(id);
                if (category == null)
                {
                    return NotFound();
                }
                return Ok(category);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("create")]
        public async Task<ActionResult<CategoryDto>> PostCategory([FromForm] CategoryWithImageDto categoryDto, IFormFile image)
        {
            try
            {
                if (categoryDto == null)
                {
                    return BadRequest("Unable to create category");
                }

                // Add the new category to the database
                var createdCategory = await _categoryService.CreateCategoryAsync(categoryDto);

                // Return 201 Created response with the created category
                return CreatedAtAction(nameof(GetCategory), new { id = createdCategory.Id }, createdCategory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, UpdateCategoryDto updateCategoryDto)
        {
            try
            {
                if (id != updateCategoryDto.Id)
                {
                    return BadRequest("Category ID mismatch");
                }

                var updatedCategory = await _categoryService.UpdateCategoryAsync(updateCategoryDto);

                if (updatedCategory == null)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}