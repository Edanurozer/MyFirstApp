using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrac
{
   public interface IContactService
    {
        List<Contact> GetList();

        void ContactAdd(Contact contact); // Categoryadd metodu,  category' den category parametresi alacak 
        Contact GetByID(int id);
        void DeleteContact(Contact contact);
        void AboutUpdate(Contact contact);
    }
}
