using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManagerBL cm = new CommentManagerBL(new EfCommentRepositoryDAL());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.CommentGetListBL(id);
            return View(values);
        }
    }
}
