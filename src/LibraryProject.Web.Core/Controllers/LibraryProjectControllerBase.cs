using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibraryProject.Controllers
{
    public abstract class LibraryProjectControllerBase: AbpController
    {
        protected LibraryProjectControllerBase()
        {
            LocalizationSourceName = LibraryProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
