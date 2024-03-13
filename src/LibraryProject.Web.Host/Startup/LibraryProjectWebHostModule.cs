using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibraryProject.Configuration;

namespace LibraryProject.Web.Host.Startup
{
    [DependsOn(
       typeof(LibraryProjectWebCoreModule))]
    public class LibraryProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibraryProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibraryProjectWebHostModule).GetAssembly());
        }
    }
}
