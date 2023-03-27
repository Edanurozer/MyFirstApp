using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        //category Repository sınıfn içinde her bir metodun görevini tanımlama


        Context c = new Context(); 
        DbSet<Category> _object; //nesne

        public void Delete(Category p)
        {
            _object.Remove(p); // parameterden gelen değeri kaldıracak
            c.SaveChanges();
               
        }

        public void Insert(Category p)
        {
            _object.Add(p); // (p) parametreden gelen değeri _object içerisinde bulunan sınıfıma ekleyecek yani category
            c.SaveChanges(); //context te değişiklikleri kaydet. EntityFramework' de değişiklikleri kaydedilmesi için kullanılan SaveChanges metodunun klasik ado net komutlarındaki karşığı savaChange==ExecuteNonQuery
        }
        
        public List<Category> List()
        {
            return _object.ToList();// category sınıfındaki değerleri tutuyor ToList entityfreamworkverileri listelemek için kullanılan metot.s
        }

        public List<Category> List(Expression<Func<Category, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
