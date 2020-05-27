using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPAngular.Configuration;
using ABPAngular.Web;

namespace ABPAngular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPAngularDbContextFactory : IDesignTimeDbContextFactory<ABPAngularDbContext>
    {
        public ABPAngularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPAngularDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPAngularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPAngularConsts.ConnectionStringName));

            return new ABPAngularDbContext(builder.Options);
        }
    }
}
