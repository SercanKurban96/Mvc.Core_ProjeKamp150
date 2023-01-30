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
    public class Message2ManagerBL : IMessage2ServiceBL
    {
        IMessage2DAL _message2Dal;

        public Message2ManagerBL(IMessage2DAL message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2Dal.GetInboxWithMessageByWriterDAL(id);
        }

        public List<Message2> GetListAllBL()
        {
            return _message2Dal.GetListAllDAL();
        }

        public List<Message2> GetSendBoxListByWriter(int id)
        {
            return _message2Dal.GetSendBoxWithMessageByWriterDAL(id);
        }

        public void TAddBL(Message2 t)
        {
            _message2Dal.InsertDAL(t);
        }

        public void TDeleteBL(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetByIdBL(int id)
        {
            return _message2Dal.GetByIdDAL(id);
        }

        public void TUpdateBL(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
