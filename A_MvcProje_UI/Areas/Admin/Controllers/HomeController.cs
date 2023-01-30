using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
