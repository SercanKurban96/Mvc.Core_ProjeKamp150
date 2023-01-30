using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Blog
{
	public class BlogLast3Post : ViewComponent
	{
		BlogManagerBL bm = new BlogManagerBL(new EfBlogRepositoryDAL());
		public IViewComponentResult Invoke()
		{
			var values = bm.GetLast3Blog();
			return View(values);
		}
	}
}
