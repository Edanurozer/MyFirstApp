
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
    public class AdminCategoryController : Controller
    {

        CategoryManeger cm = new CategoryManeger(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory( Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
                return RedirectToAction("Index"); // ındex aksiyonuna yönlendirecek eğer girilen değerler geçerliyse
            }
            else
            {
                foreach (var item in results.Errors)       
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }

            return View();
        }
        
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);
            cm.DeleteCategroy(categoryvalue);

            return RedirectToAction("Index");
        }
        [HttpGet] //sayfa yüklendiğinde çalışacak
        public ActionResult EditCategory(int id)
        {

            var categoryvalue = cm.GetByID(id); // id değişkeninden parametre değerine göre ilgili satırın kayıtlarını categoryvalue isimli değişgenime atayacak
            return View(categoryvalue); // değişgenle beraber döndürecek
        }
        [HttpPost] 
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
            
        }



    }
}