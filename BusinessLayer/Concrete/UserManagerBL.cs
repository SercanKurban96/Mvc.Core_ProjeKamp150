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
    public class UserManagerBL : IUserServiceBL
    {
        IUserDAL _userDal;

        public UserManagerBL(IUserDAL userDal)
        {
            _userDal = userDal;
        }

        public List<AppUser> GetListAllBL()
        {
            throw new NotImplementedException();
        }

        public void TAddBL(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByIdBL(int id)
        {
            return _userDal.GetByIdDAL(id);
        }

        public void TUpdateBL(AppUser t)
        {
            _userDal.UpdateDAL(t);
        }
    }
}
