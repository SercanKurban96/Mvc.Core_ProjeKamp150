using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CommentManagerBL : ICommentServiceBL
	{
		ICommentDAL _commentDal;

		public CommentManagerBL(ICommentDAL commentDal)
		{
			_commentDal = commentDal;
		}

		public void CommentDeleteBL(Comment comment)
		{
			throw new NotImplementedException();
		}

		public Comment CommentGetByIdBL(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> CommentGetListBL(int id)
		{
			return _commentDal.GetListAllDAL(x => x.BlogID == id);
		}

		public void CommentInsertBL(Comment comment)
		{
			_commentDal.InsertDAL(comment);
		}

		public void CommentUpdateBL(Comment comment)
		{
			throw new NotImplementedException();
		}

        public List<Comment> GetCommentWithBlog()
        {
			return _commentDal.GetListWithBlogDAL();
        }
    }
}
