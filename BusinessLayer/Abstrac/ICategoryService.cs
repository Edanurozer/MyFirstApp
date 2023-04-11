using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrac
{
    public interface ICategoryService
    {
        List<Category> GetList();

        void CategoryAdd(Category category); // Categoryadd metodu,  category' den category parametresi alacak 
        Category GetByID(int id);
        void DeleteCategroy(Category category);
        void CategoryUpdate(Category category);



    }
}
