using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrac
{
   public interface IMessageService
    {
        List<Message> GetList();

        void MessageAdd(Message message); // Categoryadd metodu,  category' den category parametresi alacak 
        Message GetByID(int id);
        void DeleteMessage(Message message);
        void MessageUpdate(Message messasge);
    }
}
