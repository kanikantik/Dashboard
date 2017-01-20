using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace CoverageDashboard.EntityFramework.Repositories
{
    public abstract class CoverageDashboardRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CoverageDashboardDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CoverageDashboardRepositoryBase(IDbContextProvider<CoverageDashboardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CoverageDashboardRepositoryBase<TEntity> : CoverageDashboardRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CoverageDashboardRepositoryBase(IDbContextProvider<CoverageDashboardDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
