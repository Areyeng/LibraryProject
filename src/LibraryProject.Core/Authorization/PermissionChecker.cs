using Abp.Authorization;
using LibraryProject.Authorization.Roles;
using LibraryProject.Authorization.Users;

namespace LibraryProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
