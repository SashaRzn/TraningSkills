using System.Web.Mvc;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return Content("Сайт находится в разработке. ©bakdob");
		}
	}
}