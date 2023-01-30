using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	public class AboutController : Controller
	{
		AboutManagerBL abm = new AboutManagerBL(new EfAboutRepositoryDAL());
		public IActionResult Index()
		{
			var values = abm.GetListAllBL();
			return View(values);
		}

		public PartialViewResult SocialMediaAbout()
		{
			
			return PartialView();
		}
	}
}
