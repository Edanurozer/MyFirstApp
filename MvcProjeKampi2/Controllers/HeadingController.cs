using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi2.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());

        CategoryManeger cm = new CategoryManeger(new EfCategoryDal());

        WriterMenager wm = new WriterMenager(new EfWriterDal());

        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem // yeni bir liste öğesini seçecek
                                                  { Text = x.CategoryName, Value = x.CategoryID.ToString() }).ToList(); // verileri dropdownlist aracı üzerinden listeleyecek
            // Dropdown iki adet parametresi olacak biri ValueNumber= Seçmiş olduğum değerin ID' si   DisplayNumber= Seçmiş olduğum değerin görünüm kısmı yani categıriadı olacak
            // ValueNumber ve DisplayNumber' ın controller' daki karşılığı Text ve Value. Text Displaynumver oluyor Value valueNumber oluyoor.


            List<SelectListItem> valuewriter = (from x in wm.GetList() select new SelectListItem { Text = x.WriterName + " " + x.WriterSurName, Value = x.WriterID.ToString() }).ToList();



            ViewBag.vlc = valuecategory; // controller üzerinde viewbag yardımı ile View'e taşıyacak
            ViewBag.vlm = valuewriter;

            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString()); // günün tarihini yazacak
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }
       public ActionResult EditHeading (int id)
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem // yeni bir liste öğesini seçecek
                                                  { Text = x.CategoryName, Value = x.CategoryID.ToString() }).ToList();

            ViewBag.vlc = valuecategory;

            var HeadingValue = hm.GetByID(id);
            return View(HeadingValue);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = hm.GetByID(id);
            HeadingValue.HeadingStatus = false;
            hm.HeadingDelete(HeadingValue); // headingvalue dan gelen değeri silecek, sonrasında beni index e yönlendirecek.
            return RedirectToAction("index");
        }
    }
}