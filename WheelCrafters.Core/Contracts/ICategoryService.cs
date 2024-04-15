using WheelCrafters.Core.Models.Category;

namespace WheelCrafters.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryViewModel>> GetAllAsync();
    }
}
