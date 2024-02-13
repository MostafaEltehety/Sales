using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SalesMvcCore.Models
{
    public class SalesDbContext : IdentityDbContext<IdentityUser>
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> opition) : base(opition)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
