using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        NotificationManagerBL nm = new NotificationManagerBL(new EfNotificationRepositoryDAL());
        public IViewComponentResult Invoke()
        {
            var values = nm.GetListAllBL();
            return View(values);
        }
    }
}
