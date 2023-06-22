using Abp.Authorization;
using azuretest6.Authorization.Roles;
using azuretest6.Authorization.Users;

namespace azuretest6.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
