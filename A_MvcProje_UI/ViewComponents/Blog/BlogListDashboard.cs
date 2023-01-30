using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManagerBL bm = new BlogManagerBL(new EfBlogRepositoryDAL());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
