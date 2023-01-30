using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        // interfacelerde sadece boş metot tanımladık
        // Görevlerini Genericrepository'de tanımlayacağız
        // metotların imzasını burada tuttuk
        // Generic: Bütüne yaymak
        void InsertDAL(T t);
        void DeleteDAL(T t);
        void UpdateDAL(T t);
        List<T> GetListAllDAL();
        T GetByIdDAL(int id);

        List<T> GetListAllDAL(Expression<Func<T, bool>> filter);
    }
}
