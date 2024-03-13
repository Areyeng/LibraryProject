using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryProject.Authorization;

namespace LibraryProject
{
    [DependsOn(
        typeof(LibraryProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LibraryProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LibraryProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LibraryProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
