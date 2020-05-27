using Abp.Authorization;
using ABPAngular.Authorization.Roles;
using ABPAngular.Authorization.Users;

namespace ABPAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
