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
    public class WriterManagerBL : IWriterServiceBL
    {
        IWriterDAL _writerDal;

        public WriterManagerBL(IWriterDAL writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetListAllBL()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAllDAL(x=>x.WriterID== id);
        }

        public void TAddBL(Writer t)
        {
            _writerDal.InsertDAL(t);
        }

        public void TDeleteBL(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetByIdBL(int id)
        {
            return _writerDal.GetByIdDAL(id);
        }

        public void TUpdateBL(Writer t)
        {
            _writerDal.UpdateDAL(t);
        }
    }
}
