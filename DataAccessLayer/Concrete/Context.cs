using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context : DbContext // dbcontext sınıfındaki  özellikler context  sınıfımın içerisine eklensin 
    {
        //entity katmanıma tanımlamış olduğum sınıfları buraya yazmam gerekiyor, başka katmanın metotlarını yada 
        //sınıflarını burada kullanmam için o katmanı buraya referans eklemem gerek 

        public DbSet<About> Abouts { get; set; } // About benim projemin içerisinde yer alan sınıfın ismi Abaouts ise bizim sql de veri tabanımıza yansıyacak olan tablonun ismi.
        // ikisi birinirine karışmasın diye birine S takısı geliyor

        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }


    }
}
