using WheelCrafters.Core.Models.Category;

namespace WheelCrafters.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<CategoryViewModel>> AllAsync();

        Task AddProductAsync(AddCategoryViewModel model);

        Task RemoveProductAsync(DeleteCategoryViewModel model);

        Task EditProductAsync(CategoryViewModel model, string name);
    }
}
