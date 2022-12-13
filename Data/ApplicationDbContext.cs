using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _605SecAssess2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Customer>? Customer { get; set; }
        public DbSet<Models.Order>? Order { get; set; }
        public DbSet<Models.Staff>? Staff { get; set; }
        public DbSet<Models.Stock>? Stock { get; set; }
    }
}