using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManagerBL nm = new NotificationManagerBL(new EfNotificationRepositoryDAL());
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult AllNotification()
        {
            var values = nm.GetListAllBL();
            return View(values);
        }
    }
}
