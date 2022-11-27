using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BussinessLayer.Abstract
{
    public class WriterManager : IWriterServices
    {

        IWriterDal writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            this.writerDal = writerDal;
        }

        public void EkleWriter(Writer cat)
        {
            writerDal.Add(cat);
        }

        public void GuncelleWriter(Writer cat)
        {
            writerDal.Update(cat);
        }

        public List<Writer> listWriters()
        {
           return writerDal.listAll();
        }
 

        public void SilWriter(Writer cat)
        {
            writerDal.Delete(cat);
        }

        public Writer SinifGetirWriter(int id)
        {
            return writerDal.getByID(id);
        }
 

    }
}
