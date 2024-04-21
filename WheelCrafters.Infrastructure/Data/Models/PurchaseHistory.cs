using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class PurchaseHistory
    {
        [Key]
        [Comment("Purchase History Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("User Identifier")]
        public int UserId { get; set; }

        public ICollection<Order> PurchasedProducts { get; set; }
            = new List<Order>();
    }
}
