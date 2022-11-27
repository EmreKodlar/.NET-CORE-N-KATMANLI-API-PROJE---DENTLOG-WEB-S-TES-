using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Abstract
{
    public class AboutManager : IAboutServices
    {

        IAboutDal aboutDal; // Önce tanımla 

        public AboutManager(IAboutDal iaboutDal)
        {
            aboutDal = iaboutDal; // sonra  new'lemeden interface'i ata! Artık tüm Generic metotlar bunun içinde.
        }

        public List<About> aboutlistele()
        {
            return aboutDal.listAll();
        }

        public void GuncelleAbout(About cat)
        {
            aboutDal.Update(cat);
        }

        public About SinifGetirAbout(int id)
        {
            return aboutDal.getByID(id);
        }

    }
}
