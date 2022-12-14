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
    public class EfCategoriesRepository : GenericRepository<Category>, ICategoryDal
    {
        public List<Category> ListWithBlog()
        {
             
                using (var c = new Context())
                {
                    return c.Categories.Include(x => x.Blog).ToList();

                }
             
        }
    }
}
