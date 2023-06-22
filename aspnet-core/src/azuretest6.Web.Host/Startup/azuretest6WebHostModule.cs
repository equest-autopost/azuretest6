using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using azuretest6.Configuration;

namespace azuretest6.Web.Host.Startup
{
    [DependsOn(
       typeof(azuretest6WebCoreModule))]
    public class azuretest6WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public azuretest6WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(azuretest6WebHostModule).GetAssembly());
        }
    }
}
