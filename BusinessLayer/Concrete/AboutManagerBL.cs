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
	public class AboutManagerBL : IAboutServiceBL
	{
		IAboutDAL _aboutDal;

		public AboutManagerBL(IAboutDAL aboutDal)
		{
			_aboutDal = aboutDal;
		}
        public About TGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetListAllBL()
        {
            return _aboutDal.GetListAllDAL();
        }

        public void TAddBL(About t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(About t)
        {
            throw new NotImplementedException();
        }
    }
}
