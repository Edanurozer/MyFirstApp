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
    public class WriterController : Controller
    {
        WriterMenager wm = new WriterMenager(new EfWriterDal());

        WriterValidator writervalidator = new WriterValidator();
        public ActionResult Index()
        {
            var WriterValues = wm.GetList(); //ekleme

            return View(WriterValues);
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
           
            ValidationResult results = writervalidator.Validate(p); // p den gelen değerleri kontrol et
            if (results.IsValid)
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage)
;               }
            }

            return View();
        }

        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writervalue = wm.GetByID(id);
            return View(writervalue);

        }

        [HttpPost]
        public ActionResult EditWriter(Writer p)
        {
            ValidationResult results = writervalidator.Validate(p); // p den gelen değerleri kontrol et
            if (results.IsValid)
            {
                wm.WriterUpdate(p); // validator geçerliyse güncelleme yapacak
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage)
;
                }
            }
            return View();
        }
    }
}