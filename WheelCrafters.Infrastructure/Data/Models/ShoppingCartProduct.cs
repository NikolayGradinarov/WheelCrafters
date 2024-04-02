using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelCrafters.Infrastructure.Data.Models
{
    public class ShoppingCartProduct
    {
        public int ShoppingCartId { get; set; }

        public virtual ShoppingCart ShoppingCart { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
