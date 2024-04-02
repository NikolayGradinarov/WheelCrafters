using System.ComponentModel.DataAnnotations.Schema;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class ShoppingCartProduct
    {
        [ForeignKey(nameof(ShoppingCart))]
        public int ShoppingCartId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
