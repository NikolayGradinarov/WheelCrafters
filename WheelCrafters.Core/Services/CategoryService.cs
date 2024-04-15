using Microsoft.EntityFrameworkCore;
using WheelCrafters.Core.Contracts;
using WheelCrafters.Core.Models.Category;
using WheelCrafters.Data;

namespace WheelCrafters.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly WheelCraftersDbContext context;

        public CategoryService(WheelCraftersDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<CategoryViewModel>> GetAllAsync()
        {
            var entities = await context
                .Categories.ToListAsync();

            return entities.Select(es => new CategoryViewModel
            {
                Name = es.Name
            });
        }
    }
}
