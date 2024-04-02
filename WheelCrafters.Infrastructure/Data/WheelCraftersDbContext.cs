using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WheelCrafters.Data
{
    public class WheelCraftersDbContext : IdentityDbContext
    {
        public WheelCraftersDbContext(DbContextOptions<WheelCraftersDbContext> options)
            : base(options)
        {
        }
    }
}
