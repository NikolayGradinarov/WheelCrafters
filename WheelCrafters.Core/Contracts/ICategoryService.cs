using WheelCrafters.Core.Models.Category;

namespace WheelCrafters.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> AllAsync();

        Task AddCategoryAsync(AddCategoryViewModel model);

        Task RemoveCategoryAsync(DeleteCategoryViewModel model);

        Task EditCategoryAsync(CategoryViewModel model, string name);
    }
}
