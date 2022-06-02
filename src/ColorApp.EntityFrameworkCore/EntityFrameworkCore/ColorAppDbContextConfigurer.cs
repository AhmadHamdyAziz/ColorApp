using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ColorApp.EntityFrameworkCore
{
    public static class ColorAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ColorAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ColorAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
