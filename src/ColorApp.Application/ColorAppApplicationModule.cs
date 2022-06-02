using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ColorApp.Authorization;

namespace ColorApp
{
    [DependsOn(
        typeof(ColorAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ColorAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ColorAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ColorAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
