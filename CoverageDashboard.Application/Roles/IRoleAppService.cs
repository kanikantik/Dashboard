using System.Threading.Tasks;
using Abp.Application.Services;
using CoverageDashboard.Roles.Dto;

namespace CoverageDashboard.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
