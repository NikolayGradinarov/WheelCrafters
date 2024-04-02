using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class ShoppingCart
    {
        [Key]
        [Comment("Shopping Cart Identifier")]
        public int Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public virtual ICollection<ShoppingCartProduct> ShoppingCartProducts { get; set; }
            = new List<ShoppingCartProduct>();
    }
}
