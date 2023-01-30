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
    public class ContactManagerBL : IContactServiceBL
    {
        IContactDAL _contactDal;

		public ContactManagerBL(IContactDAL contactDal)
		{
			_contactDal = contactDal;
		}

		public void ContactDeleteBL(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Contact ContactGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> ContactGetListBL()
        {
            throw new NotImplementedException();
        }

        public void ContactInsertBL(Contact contact)
        {
            _contactDal.InsertDAL(contact);
        }

        public void ContactUpdateBL(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
