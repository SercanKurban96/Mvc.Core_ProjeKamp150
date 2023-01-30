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
    public class NewsLetterManagerBL : INewsLetterServiceBL
    {
        INewsLetterDAL _newsletterDal;

        public NewsLetterManagerBL(INewsLetterDAL newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public void AddNewsLetterBL(NewsLetter newsLetter)
        {
            _newsletterDal.InsertDAL(newsLetter);
        }
    }
}
