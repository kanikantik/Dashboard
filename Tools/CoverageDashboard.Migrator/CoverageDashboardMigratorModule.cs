using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using CoverageDashboard.EntityFramework;

namespace CoverageDashboard.Migrator
{
    [DependsOn(typeof(CoverageDashboardDataModule))]
    public class CoverageDashboardMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CoverageDashboardDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}