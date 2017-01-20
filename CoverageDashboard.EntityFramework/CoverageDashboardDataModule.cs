using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using CoverageDashboard.EntityFramework;

namespace CoverageDashboard
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(CoverageDashboardCoreModule))]
    public class CoverageDashboardDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CoverageDashboardDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
