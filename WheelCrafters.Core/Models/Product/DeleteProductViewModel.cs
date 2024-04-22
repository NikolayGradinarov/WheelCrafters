namespace WheelCrafters.Core.Models.Product
{
    public class DeleteProductViewModel
    {
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Infrastructure.Data.Models.Product> Products { get; set; }
            = new List<Infrastructure.Data.Models.Product>();
    }
}
