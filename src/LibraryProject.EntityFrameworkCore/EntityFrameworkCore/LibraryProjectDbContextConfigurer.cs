using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.EntityFrameworkCore
{
    public static class LibraryProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LibraryProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LibraryProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
