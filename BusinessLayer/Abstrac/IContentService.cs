using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrac
{
   public interface IContentService
    {

        List<Content> GetList();
        List<Content> GetListByHeadingID(int id); // İD ye göre sbütün listeyi döndürecek
        void ContentAdd(Content content); // Categoryadd metodu,  category' den category parametresi alacak 
        Content GetByID(int id);
        void DeleteContent(Content content);
        void ContentUpdate(Content content);



        
    }
}
