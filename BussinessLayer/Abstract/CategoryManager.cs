using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Abstract
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _icategoryDal; // Önce tanımla 

        public CategoryManager(ICategoryDal icategoryDal)
        {
            _icategoryDal = icategoryDal; // sonra  new'lemeden interface'i ata! Artık tüm Generic metotlar bunun içinde.
        }

        public void EkleCategory(Category cat)
        {
            _icategoryDal.Add(cat);
        }

        public void GuncelleCategory(Category cat)
        {
            _icategoryDal.Update(cat);
        }

        //public int KategorilerdekiBlogSayisi(int id)
        //{
        //    return _icategoryDal.SartliListele(id);
        //}

        public List<Category> KategoriyiBloglaBeraberKullan()
        {
            return _icategoryDal.ListWithBlog();
        }

        public List<Category> listCategories()
        {
            return _icategoryDal.listAll();
        }

        public void SilCategory(Category cat)
        {
            _icategoryDal.Delete(cat);
        }

        public Category SinifGetirCategory(int id)
        {
            return _icategoryDal.getByID(id);
        }

      

    }
}
