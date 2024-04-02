using Microsoft.AspNetCore.Identity;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public virtual PurchaseHistory PurchaseHistory { get; set; } = new PurchaseHistory();

        public virtual ShoppingCart ShoppingCart { get; set; } = new ShoppingCart();
    }
}
