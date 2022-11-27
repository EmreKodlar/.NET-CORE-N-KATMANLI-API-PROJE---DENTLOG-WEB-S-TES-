using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> ListWithCategory()
        {
            using (var c=new Context())
            {
                return c.Blogs.Include(x=>x.Category).ToList();
                
            }
        }

        public List<Blog> BlogKategoriYorumListesi()
        {

            using (var c = new Context())
            {
                return c.Blogs
                    .Include(x => x.Category) // Kategorinin hepsi
                    .Include(x => x.Writer)
                     
                    .ToList();

            }

        }

        
    }
}
