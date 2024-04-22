using WheelCrafters.Core.Models.Product;

namespace WheelCrafters.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> AllAsync();

        Task AddProductAsync(AddProductViewModel model);

        Task RemoveProductAsync(DeleteProductViewModel model);

        Task EditProductAsync(ProductViewModel model, string name);

        Task AddProductToCart(string userId, string name);
    }
}
