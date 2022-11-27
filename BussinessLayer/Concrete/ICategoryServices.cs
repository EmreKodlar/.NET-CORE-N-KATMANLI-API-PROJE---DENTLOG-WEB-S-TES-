using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Concrete
{
    public interface ICategoryServices
    {
        List<Category> listCategories();
        void EkleCategory(Category cat);
        void SilCategory(Category cat);
        void GuncelleCategory(Category cat);
        Category SinifGetirCategory(int id);

        List<Category> KategoriyiBloglaBeraberKullan();

        //int KategorilerdekiBlogSayisi(int id);



    }
}
