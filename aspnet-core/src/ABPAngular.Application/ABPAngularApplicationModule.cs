using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPAngular.Authorization;

namespace ABPAngular
{
    [DependsOn(
        typeof(ABPAngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPAngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPAngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPAngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
