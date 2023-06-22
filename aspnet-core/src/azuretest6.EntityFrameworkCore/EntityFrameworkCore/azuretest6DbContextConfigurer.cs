using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace azuretest6.EntityFrameworkCore
{
    public static class azuretest6DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<azuretest6DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<azuretest6DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
