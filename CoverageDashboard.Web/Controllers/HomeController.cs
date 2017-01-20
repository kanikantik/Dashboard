using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace CoverageDashboard.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CoverageDashboardControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}