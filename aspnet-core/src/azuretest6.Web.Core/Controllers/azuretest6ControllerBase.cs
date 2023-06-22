using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace azuretest6.Controllers
{
    public abstract class azuretest6ControllerBase: AbpController
    {
        protected azuretest6ControllerBase()
        {
            LocalizationSourceName = azuretest6Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
