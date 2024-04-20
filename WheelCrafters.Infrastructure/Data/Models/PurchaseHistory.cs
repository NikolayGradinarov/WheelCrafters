using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class PurchaseHistory
    {
        [Key]
        [Comment("Purchase History Identifier")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [Comment("User Identifier")]
        public Guid UserId { get; set; }

        public ICollection<Order> PurchasedProducts { get; set; }
            = new List<Order>();
    }
}
