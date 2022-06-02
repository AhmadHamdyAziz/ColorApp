using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ColorApp.Authorization.Roles;
using ColorApp.Authorization.Users;
using ColorApp.MultiTenancy;

namespace ColorApp.EntityFrameworkCore
{
    public class ColorAppDbContext : AbpZeroDbContext<Tenant, Role, User, ColorAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Color.Color> Colors { get; set; }

        public ColorAppDbContext(DbContextOptions<ColorAppDbContext> options)
            : base(options)
        {
        }
    }
}
