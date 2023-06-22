using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using azuretest6.Configuration;
using azuretest6.Web;

namespace azuretest6.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class azuretest6DbContextFactory : IDesignTimeDbContextFactory<azuretest6DbContext>
    {
        public azuretest6DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<azuretest6DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            azuretest6DbContextConfigurer.Configure(builder, configuration.GetConnectionString(azuretest6Consts.ConnectionStringName));

            return new azuretest6DbContext(builder.Options);
        }
    }
}
