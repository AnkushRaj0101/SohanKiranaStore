using Microsoft.EntityFrameworkCore;
using SohanKiranaStore.Model.DTO;
using SohanKiranaStore.Model.Models;
using SohanKiranaStore.Repository.DBContect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Core.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDto>> GetCategoriesAsync();
        Task<CategoryDto> GetCategoryAsync(int id);
        Task<CategoryDto> CreateCategoryAsync(CategoryDto categoryDto);
        Task<CategoryDto> UpdateCategoryAsync(UpdateCategoryDto categoryDto);
    }
    public class CategoryService : ICategoryService
    {
        private readonly SohanKiranaContext _context;

        public CategoryService(SohanKiranaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _context.Categories
                .Include(c => c.Products)
                    .ThenInclude(p => p.ProductSizes)
                        .ThenInclude(ps => ps.Size)
                .Include(c => c.Products)
                    .ThenInclude(p => p.Description)
                .ToListAsync();

            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Products = c.Products.Select(p => new ProductDto
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Sizes = p.ProductSizes.Select(ps => new SizeDto
                    {
                        SizeId = ps.Size.SizeId,
                        Description = ps.Size.Description,
                        Price = ps.Price
                    }).ToList(),
                    Description = new DescriptionDto
                    {
                        DescriptionId = p.Description.DescriptionId,
                        ProductDescription = p.Description.ProductDescription,
                        Features = p.Description.Features,
                        OtherProductInfo = p.Description.OtherProductInfo
                    }
                }).ToList()
            });
        }

        public async Task<CategoryDto> GetCategoryAsync(int id)
        {
            var category = await _context.Categories
                .Include(c => c.Products)
                    .ThenInclude(p => p.ProductSizes)
                        .ThenInclude(ps => ps.Size)
                .Include(c => c.Products)
                    .ThenInclude(p => p.Description)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                return null;
            }

            return new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Products = category.Products.Select(p => new ProductDto
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Sizes = p.ProductSizes.Select(ps => new SizeDto
                    {
                        SizeId = ps.Size.SizeId,
                        Description = ps.Size.Description,
                        Price = ps.Price
                    }).ToList(),
                    Description = new DescriptionDto
                    {
                        DescriptionId = p.Description.DescriptionId,
                        ProductDescription = p.Description.ProductDescription,
                        Features = p.Description.Features,
                        OtherProductInfo = p.Description.OtherProductInfo
                    }
                }).ToList()
            };
        }
        public async Task<CategoryDto> CreateCategoryAsync(CategoryDto categoryDto)
        {
            var newCategory = new Category
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description
            };

            _context.Categories.Add(newCategory);
            await _context.SaveChangesAsync();

            return new CategoryDto
            {
                Id = newCategory.Id,
                Name = newCategory.Name,
                Description = newCategory.Description
            };
        }

        public async Task<CategoryDto> UpdateCategoryAsync(UpdateCategoryDto categoryDto)
        {
            var existingCategory = await _context.Categories.FindAsync(categoryDto.Id);

            if (existingCategory == null)
            {
                return null; // Or throw an exception if required
            }

            existingCategory.Name = categoryDto.Name;
            existingCategory.Description = categoryDto.Description;

            _context.Categories.Update(existingCategory);
            await _context.SaveChangesAsync();

            return new CategoryDto
            {
                Id = existingCategory.Id,
                Name = existingCategory.Name,
                Description = existingCategory.Description
            };

        }
    }
}
