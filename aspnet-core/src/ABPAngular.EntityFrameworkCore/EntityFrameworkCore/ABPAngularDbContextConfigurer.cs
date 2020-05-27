using System;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPAngular.EntityFrameworkCore
{
    public static class ABPAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPAngularDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(
                connectionString,
                options => options.SetPostgresVersion(new Version(9, 6)));
        }

        public static void Configure(DbContextOptionsBuilder<ABPAngularDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);
        }
    }
}
