using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ColorApp.Controllers
{
    public abstract class ColorAppControllerBase: AbpController
    {
        protected ColorAppControllerBase()
        {
            LocalizationSourceName = ColorAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
