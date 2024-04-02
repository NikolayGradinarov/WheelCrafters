using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WheelCrafters.Infrastructure.Data.Models;

namespace WheelCrafters.Data
{
    public class WheelCraftersDbContext : IdentityDbContext
    {
        public WheelCraftersDbContext(DbContextOptions<WheelCraftersDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<ShoppingCartProduct> ShoppingCartProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OrderProduct>()
                .HasKey(o => new { o.OrderId, o.ProductId });
            builder.Entity<ShoppingCartProduct>()
                .HasKey(s => new { s.ShoppingCartId, s.ProductId });

            base.OnModelCreating(builder);
        }
    }
}
