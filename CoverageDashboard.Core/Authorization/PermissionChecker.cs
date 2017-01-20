using Abp.Authorization;
using CoverageDashboard.Authorization.Roles;
using CoverageDashboard.MultiTenancy;
using CoverageDashboard.Users;

namespace CoverageDashboard.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
