using Microsoft.EntityFrameworkCore;
using WheelCrafters.Core.Contracts;
using WheelCrafters.Core.Models.Category;
using WheelCrafters.Data;
using WheelCrafters.Infrastructure.Data.Models;

namespace WheelCrafters.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly WheelCraftersDbContext context;

        public CategoryService(WheelCraftersDbContext _context)
        {
            context = _context;
        }

        public async Task AddCategoryAsync(AddCategoryViewModel model)
        {
            var entity = new Category()
            {
                Id = Guid.NewGuid(),
                Name = model.Name
            };

            if (context.Categories.Any(ca => ca.Name == model.Name))
            {
                throw new InvalidOperationException("A category with the same name already exists.");
            }

            await context.Categories.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryViewModel>> AllAsync()
        {
            var entities = await context
                .Categories.ToListAsync();

            return entities.Select(es => new CategoryViewModel
            {
                Name = es.Name
            });
        }

        public async Task EditCategoryAsync(CategoryViewModel model, string name)
        {
            var categ = context
                .Categories
                .FirstOrDefault(ca => ca.Name == name);

            var editCateg = context
                .Categories
                .FirstOrDefault(ca => ca.Name == model.Name);

            if (editCateg != null && categ != editCateg)
            {
                throw new ArgumentException("Name already exists!");
            }

            categ.Name = model.Name;

            await context.SaveChangesAsync();
        }

        public async Task RemoveCategoryAsync(DeleteCategoryViewModel model)
        {
            Category? categ = await context
                .Categories.Include(ca => ca.Products)
                .FirstOrDefaultAsync(ca => ca.Name == model.Name);

            if (categ == null)
            {
                throw new InvalidOperationException("A category with this name doesn't exist.");
            }

            if (categ.Products.Any())
            {
                throw new InvalidOperationException("There are already products in the category");
            }

            context.Categories.Remove(categ);
            await context.SaveChangesAsync();
        }
    }
}
