using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class // T değeri alacak ınterface olarak değerlerini Irepository den alacak göndereceğim T değeri bir class olmalı
    {

        Context C = new Context();

        
        DbSet<T> _object; // T değerine karşılık gelen sınıfı tutuyor.

        //burada T değerine karşılık olarak gelecek sınıfı bulucam
        public GenericRepository() //ctor yazıp iki kere tab tuşuna basınca otomatik geliyor.
        {
            _object = C.Set<T>(); // Contxt te bağlı olarak gönderilen T değeri olacak. object isimli fieldım dışarıdan gönderdiğim entity neyse o olacak 
        }

        public void Delete(T p)
        {
            var deletedEntity = C.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            //_object.Remove(p);
            C.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> Filter)
        {
            return _object.SingleOrDefault(Filter); //SingleOrDefaul methodu ile geriye filter' dan gelen değeri döndürecek
             //GenericRepository içerisinde bu method tanımlandığı için, GenericRepository' den miras alan bütün sınıflarda da bu method geçerli olacak
        }

        public void Insert(T p)
        {
            var addedEntity = C.Entry(p); // Context' en türetmiş olduğum nesne(Entry "giriş") ekleyeceğim değeri addedentity isimli değişgene atanmış oldu
            addedEntity.State = EntityState.Added; //state durum- ekleme işlemini entitystate üzerinden gerçekleştirildi.
            // _object.Add(p);
            C.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList(); //listeyi döndür

         
        }

        public List<T> List(Expression<Func<T, bool>> Filter)
        {
            return _object.Where(Filter).ToList(); // where(şart) Filter dan gelen değere göre bana listele
        }

        public void Update(T p)
        {
            var updatedEntity = C.Entry(p);
            updatedEntity.State = EntityState.Modified; // Modifies- içinden 
            C.SaveChanges();
        }
    }
}
