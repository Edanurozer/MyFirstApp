﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstrac
{
  public  interface IAboutService
    {
        List<About> GetList();

        void AboutAdd(About about); // Categoryadd metodu,  category' den category parametresi alacak 
        About GetByID(int id);
        void DeleteAbout(About about);
        void AboutUpdate(About about);
    }
}
