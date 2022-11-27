using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetCore_PROJE.ViewComponents.Blog
{
    public class BlogListFromWriter : ViewComponent
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke(int id)
        { 

            var values = bm.BlogIDileYazarinSon5Yazisi(id);
          
            return View(values);
        }

    }
}
