using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Concrete
{
    public interface IAboutServices
    {    
        void GuncelleAbout(About cat);

        List<About> aboutlistele();
   
    }
}
