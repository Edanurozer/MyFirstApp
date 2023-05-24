using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi2.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm=new AboutManager(new EfAboutDal())
        
        public ActionResult Index()
        {
            return View();
        }
    }
}