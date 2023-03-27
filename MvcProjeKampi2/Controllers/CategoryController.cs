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
        public ActionResult AddCategory( Category p)
        {

            //cm.CategoryAddBL(p);

            CategoryValidator cv = new CategoryValidator();
           
            
            return RedirectToAction("GetCategoryList"); // ekleme işlemini gerçeleştirdikten sonra GetCategoryList metoduna yönlendirecek(verilerin listelendiği metot)

        }
     
    }
}