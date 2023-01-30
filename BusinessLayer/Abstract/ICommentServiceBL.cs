using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentServiceBL
    {
        void CommentInsertBL(Comment comment);
        void CommentDeleteBL(Comment comment);
        void CommentUpdateBL(Comment comment);
        List<Comment> CommentGetListBL(int id);
        Comment CommentGetByIdBL(int id);

        List<Comment> GetCommentWithBlog();
    }
}
