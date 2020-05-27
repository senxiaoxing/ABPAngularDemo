using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPAngular.Controllers
{
    public abstract class ABPAngularControllerBase: AbpController
    {
        protected ABPAngularControllerBase()
        {
            LocalizationSourceName = ABPAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
