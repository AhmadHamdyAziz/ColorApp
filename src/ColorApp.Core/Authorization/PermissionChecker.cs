using Abp.Authorization;
using ColorApp.Authorization.Roles;
using ColorApp.Authorization.Users;

namespace ColorApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
