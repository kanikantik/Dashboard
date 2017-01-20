using CoverageDashboard.EntityFramework;
using EntityFramework.DynamicFilters;

namespace CoverageDashboard.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly CoverageDashboardDbContext _context;

        public InitialHostDbBuilder(CoverageDashboardDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
