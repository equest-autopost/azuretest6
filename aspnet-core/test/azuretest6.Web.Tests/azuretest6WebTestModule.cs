using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using azuretest6.EntityFrameworkCore;
using azuretest6.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace azuretest6.Web.Tests
{
    [DependsOn(
        typeof(azuretest6WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class azuretest6WebTestModule : AbpModule
    {
        public azuretest6WebTestModule(azuretest6EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(azuretest6WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(azuretest6WebMvcModule).Assembly);
        }
    }
}