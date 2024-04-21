using System.ComponentModel.DataAnnotations.Schema;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class OrderProduct
    {
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}
