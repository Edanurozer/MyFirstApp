using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IRepository<T> // T değeri sql den hangi  entity' i istersek onu karşılayacak
    {
        List<T> List();

        void Insert(T p); // parametreyi T den alıcaz

        T Get(Expression<Func<T, bool>> Filter); 

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T, bool>> Filter); // şartlı listeleme yani istediğim ifadedeki değeri getirecek.


    }
}
