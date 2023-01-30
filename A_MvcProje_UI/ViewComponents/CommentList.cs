using A_MvcProje_UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>()
			{
				new UserComment
				{
					ID= 1,
					Username="Sercan"
				},
				new UserComment
				{
					ID= 2,
					Username="Dilber"
				},
				new UserComment
				{
					ID= 3,
					Username="Deneme"
				}
			};
			return View(commentvalues);
		}
	}
}
