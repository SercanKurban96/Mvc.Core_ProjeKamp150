using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManagerBL : IBlogServiceBL
    {
        IBlogDAL _blogDal;

        public BlogManagerBL(IBlogDAL blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAllDAL().Take(3).ToList();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategoryDAL();
        }

        public List<Blog> GetListWithCategoryByWriterBM(int id)
        {
            return _blogDal.GetListWithCategoryByWriterDAL(id);
        }

        public List<Blog> GetBlogByID(int id) 
        {
            return _blogDal.GetListAllDAL(x => x.BlogID == id);
        }

		public List<Blog> GetBlogListWithByWriter(int id)
        {
            return _blogDal.GetListAllDAL(x => x.WriterID == id);

        }

        public void TAddBL(Blog t)
        {
            _blogDal.InsertDAL(t);
        }

        public void TDeleteBL(Blog t)
        {
            _blogDal.DeleteDAL(t);
        }

        public void TUpdateBL(Blog t)
        {
            _blogDal.UpdateDAL(t);
        }

        public List<Blog> GetListAllBL()
        {
            return _blogDal.GetListAllDAL();
        }

        public Blog TGetByIdBL(int id)
        {
            return _blogDal.GetByIdDAL(id);
        }
    }
}
