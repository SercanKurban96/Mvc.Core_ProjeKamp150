using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Writer
{   
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManagerBL wm = new WriterManagerBL(new EfWriterRepositoryDAL());

        Context c = new Context();

		public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            ViewBag.v = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
