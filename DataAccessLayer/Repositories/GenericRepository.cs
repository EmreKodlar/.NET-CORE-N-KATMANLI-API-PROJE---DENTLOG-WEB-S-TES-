using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Repositories
{
    
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T t)
        {
            using var c = new Context(); // Context Sınıfını burada çağırıyoruz. 
            c.Add(t);
            c.SaveChanges();

        }

        public void Delete(T t)
        {
            using var c = new Context(); // Context Sınıfını burada çağırıyoruz. 
            c.Remove(t);
            c.SaveChanges();
        }

        public T getByID(int id)
        {
            using var c = new Context(); // Context Sınıfını burada çağırıyoruz. 
            return c.Set<T>().Find(id);
        }

        //public int IDGEtir(Expression<Func<T, bool>> filter)
        //{
        //    using var c = new Context(); // Context Sınıfını burada çağırıyoruz. 
        //    var emre = c.Set<T>().Where(filter).SingleOrDefault();
        //    return  Convert.ToInt32(emre) ;
        //}

        public List<T> listAll()
        {
            using var c = new Context(); // Context Sınıfını burada çağırıyoruz. 
            return c.Set<T>().ToList();
        }

        public List<T> SartliListele(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            using var c = new Context(); // Context Sınıfını burada çağırıyoruz. 
            c.Update(t);
            c.SaveChanges();
        }
    }
}
