using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using azuretest6.Authorization;

namespace azuretest6
{
    [DependsOn(
        typeof(azuretest6CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class azuretest6ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<azuretest6AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(azuretest6ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
