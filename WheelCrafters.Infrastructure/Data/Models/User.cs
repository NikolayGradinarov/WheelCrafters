using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public virtual PurchaseHistory PurchaseHistory { get; set; } = new PurchaseHistory();

        public virtual ShoppingCart ShoppingCart { get; set; } = new ShoppingCart();
    }
}
