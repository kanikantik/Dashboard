using Abp.Web.Mvc.Views;

namespace CoverageDashboard.Web.Views
{
    public abstract class CoverageDashboardWebViewPageBase : CoverageDashboardWebViewPageBase<dynamic>
    {

    }

    public abstract class CoverageDashboardWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CoverageDashboardWebViewPageBase()
        {
            LocalizationSourceName = CoverageDashboardConsts.LocalizationSourceName;
        }
    }
}