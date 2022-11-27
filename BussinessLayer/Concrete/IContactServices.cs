using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Concrete
{
    public interface IContactServices
    {
        List<Category> listContacts();
        void EkleContact(Category cat);
        void SilContact(Category cat);
        void GuncelleContact(Category cat);
        Category SinifGetirContact(int id);



    }
}
