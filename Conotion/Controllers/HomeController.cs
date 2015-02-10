using System.Web.Mvc;
using Conotion.Models.Context;

namespace Conotion.Controllers
{
    [Authorize]
	[RequireHttps]
	public class HomeController : Controller
	{
	    public HomeController(IConotionContext context)
	    {
	            
	    }
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}