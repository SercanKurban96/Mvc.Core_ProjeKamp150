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
    public class MessageManagerBL : IMessageServiceBL
    {
        IMessageDAL _messageDal;

        public MessageManagerBL(IMessageDAL messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> GetListAllBL()
        {
            return _messageDal.GetListAllDAL();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetListAllDAL(x => x.Receiver == p);
        }

        public void TAddBL(Message t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
