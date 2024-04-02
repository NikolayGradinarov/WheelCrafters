using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WheelCrafters.Infrastructure.Data.Models
{
    [Comment("Rims Order")]
    public class Order
    {
        [Key]
        [Comment("Order Identifier")]
        public int Id { get; set; }

        [ForeignKey(nameof(PurchaseHistory))]
        public int PurchaseHistoryId { get; set; }

        [Required]
        public virtual PurchaseHistory PurchaseHistory { get; set; } = null!;

        public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

        [Comment("Order Date")]
        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Comment("Final Order Price")]
        [Required]
        public decimal FinalPrice { get; set; }
    }
}
