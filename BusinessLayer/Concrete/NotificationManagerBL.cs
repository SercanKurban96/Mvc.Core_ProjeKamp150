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
    public class NotificationManagerBL : INotificationServiceBL
    {
        INotificationDAL _notificationDal;

        public NotificationManagerBL(INotificationDAL notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public List<Notification> GetListAllBL()
        {
            return _notificationDal.GetListAllDAL();
        }

        public void TAddBL(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TDeleteBL(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification TGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdateBL(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
