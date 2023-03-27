using BusinessLayer.Abstrac;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManeger : ICategoryService // ınterface ' sinde tanımlanan metotları kalıtsal yollarda üzerine al 
    {

        ICategoryDal _categoryDal; // categorydal' dan field türet 

        public CategoryManeger(ICategoryDal categoryDal) // _categorydal 'a categorydal'dan başka bir değerin ataması gerçekleşti
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }



        // GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL() //hepsini getir
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBL ( Category p) //category sınıfından türetilen p parametresi 
        //{
        //if(p.CategoryName =="" || p.CategoryName.Length<=3 || p.CategoryDescription=="" || p.CategoryName.Length>=51)
        //{
        //    // hta meşajı  eğerki benim dışarıdan gönderdiğim parametre bunlardan herhagibi birine takılırsa hata mesajı verecek 
        //}
        //else
        //{ 
        //  repo.Insert(p);
        //}
        //    }
        public List<Category> GetList()
        {
            return _categoryDal.List(); // 
        }

        
    }
}
