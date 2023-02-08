using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DynamicMenuInCore.Models
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<SubMenuItem> SubMenuItem { get; set; }
        public DbSet<MenuRolePermission> MenuRolePermission { get; set; }
    }
}
