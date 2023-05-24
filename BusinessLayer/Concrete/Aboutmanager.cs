using BusinessLayer.Abstrac;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class AboutManager: IAboutService
    {
        IAbaoutDal _aboutDal;

        public AboutManager(IAbaoutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            _aboutDal.Insert(about);
        }

        public void AboutUpdate(About about)
        {
            _aboutDal.Update(about);
        }

        public void DeleteAbout(About about)
        {
            _aboutDal.Delete(about);
        }

        public About GetByID(int id)
        {
            return _aboutDal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }
    }
}
