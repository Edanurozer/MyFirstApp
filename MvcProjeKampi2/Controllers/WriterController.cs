using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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

        public ActionResult Index()
        {
            var WriterValues = wm.GetList(); //ekleme
            return View(WriterValues);
        }
    }
}