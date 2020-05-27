using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPAngular.Authorization.Roles;
using ABPAngular.Authorization.Users;
using ABPAngular.MultiTenancy;
using Abp.Localization;

namespace ABPAngular.EntityFrameworkCore
{
    public class ABPAngularDbContext : AbpZeroDbContext<Tenant, Role, User, ABPAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPAngularDbContext(DbContextOptions<ABPAngularDbContext> options)
            : base(options)
        {
        }

        // add these lines to override max length of property
        // we should set max length smaller than the PostgreSQL allowed size (10485760)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
