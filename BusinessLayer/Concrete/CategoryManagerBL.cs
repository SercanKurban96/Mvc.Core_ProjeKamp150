using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManagerBL : ICategoryServiceBL
    {
        ICategoryDAL _categoryDal;

        public CategoryManagerBL(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public Category TGetByIdBL(int id)
        {
            return _categoryDal.GetByIdDAL(id);
        }
        public List<Category> GetListAllBL()
        {
            return _categoryDal.GetListAllDAL();
        }
        public void TAddBL(Category t)
        {
            _categoryDal.InsertDAL(t);
        }
        public void TDeleteBL(Category t)
        {
            _categoryDal.DeleteDAL(t);
        }
        public void TUpdateBL(Category t)
        {
            _categoryDal.UpdateDAL(t);
        }
    }
}