using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi2.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManeger cm = new CategoryManeger( new EfCategoryDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
          var categoryvalues = cm.GetList(); // var türünün kullanma sebebi göndereceğim tabloda sayısal veya alfabetik veriler olabilir var türü hepsini kapsıyor

            return View(categoryvalues); // categoryvalues te ki değerler view' e aktarılmış olacak
        }
        
        [HttpGet] // sayfa yüklendiğinde çalışacak
        public ActionResult AddCategory()
        {
            return View();
        }


        [HttpPost] // sayfamda bir butona tıkladığım zaman sayfada birşey post edildiğinde zaman httppost çalışacak
        public ActionResult AddCategory(Category category)
        { 
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(category);// results isminde değişken oluşturdum, değişken türü ValidationResult, cv den gelen değerlere göre validasyom yap(kontrol) 
            if(results.IsValid) // eğer sonuç validasyona uygun olursa
            {
                cm.CategoryAdd(category);
                return RedirectToAction("GetCategoryList"); //doğruluk sağlandıysa getcategorylist aksiyona yönlendirecek
            }
            else
            {
                foreach (var item in results.Errors)// var-değişken türü, item-değişken bilgisi, in-içinden, cellection-dizinin adı
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//modelin durumuna hataları ekle(categorynamevs.) 
                }
            }
            return View(); 
        }
     
    }
}