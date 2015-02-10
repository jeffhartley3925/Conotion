using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject.Http;

namespace Conotion
{
	using Conotion.Models;

	public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			System.Data.Entity.Database.SetInitializer(new ConotionDatabaseInitializer());
            NinjectHttpContainer.RegisterAssembly();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

			var db = new ConotionContext();
			db.Database.Initialize(true);
        }
    }
}
