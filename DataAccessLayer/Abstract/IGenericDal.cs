using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> listAll();
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T getByID(int id);
        List<T> SartliListele(Expression<Func<T, bool>> filter);
        //T IDGEtir(Expression<Func<T, bool>> filter);

    }
}

