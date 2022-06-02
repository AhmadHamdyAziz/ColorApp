using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ColorApp.EntityFrameworkCore;
using ColorApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ColorApp.Web.Tests
{
    [DependsOn(
        typeof(ColorAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ColorAppWebTestModule : AbpModule
    {
        public ColorAppWebTestModule(ColorAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ColorAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ColorAppWebMvcModule).Assembly);
        }
    }
}