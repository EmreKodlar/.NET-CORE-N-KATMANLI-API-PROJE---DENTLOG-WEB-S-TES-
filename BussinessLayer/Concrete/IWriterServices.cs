using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BussinessLayer.Concrete
{
    public interface IWriterServices
    {
        List<Writer> listWriters();
        void EkleWriter(Writer cat);
        void SilWriter(Writer cat);
        void GuncelleWriter(Writer cat);
        Writer SinifGetirWriter(int id);

        //int idAl(string mail);
        
         
         

    }
}
