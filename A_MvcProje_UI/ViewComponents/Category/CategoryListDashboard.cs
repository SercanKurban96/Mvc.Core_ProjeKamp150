using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Category
{
    public class CategoryListDashboard : ViewComponent
    {
        CategoryManagerBL cm = new CategoryManagerBL(new EfCategoryRepositoryDAL());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetListAllBL();
            return View(values);
        }
    }
}
