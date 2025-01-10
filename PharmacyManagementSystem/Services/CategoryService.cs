using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementSystem.Models;

namespace PharmacyManagementSystem.Services
{
    public class CategoryService 
    {
        private readonly PharmacyContext _context;

        // Constructor injection
        public CategoryService()
        {
            _context = new PharmacyContext();
        }

        // Lấy tất cả các danh mục
        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }
        // Lấy tên tất cả các danh mục
        public async Task<IEnumerable<string>> GetAllCategoriesNameAsync()
        {
            return await _context.Categories.Select(c =>  c.Name).ToListAsync();
        }
        // Lấy danh mục theo ID
        public async Task<Category> GetCategoryByIdAsync(Guid categoryId)
        {
            return await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryID == categoryId);
        }

        // Thêm mới danh mục
        public async Task CreateCategoryAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        // Cập nhật danh mục
        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        // Xóa danh mục
        public async Task DeleteCategoryAsync(string categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
