using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Blog
{
	public class WriterLastBlog : ViewComponent
	{
		BlogManagerBL bm = new BlogManagerBL(new EfBlogRepositoryDAL());

		public IViewComponentResult Invoke()
		{
			var values = bm.GetBlogListWithByWriter(1);
			return View(values);
		}
	}
}
