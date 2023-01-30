using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManagerBL cm = new CommentManagerBL(new EfCommentRepositoryDAL());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogID = 2;
			cm.CommentInsertBL(p);
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
		{
			var valCom = cm.CommentGetListBL(id);
			return PartialView(valCom);
		}
	}
}
