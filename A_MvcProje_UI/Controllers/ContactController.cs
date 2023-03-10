using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		ContactManagerBL cm = new ContactManagerBL(new EfContactRepositoryDAL());
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Contact p)
		{
			p.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.ContactStatus = true;
			cm.ContactInsertBL(p);
			return RedirectToAction("Index","Blog");
		}
	}
}
