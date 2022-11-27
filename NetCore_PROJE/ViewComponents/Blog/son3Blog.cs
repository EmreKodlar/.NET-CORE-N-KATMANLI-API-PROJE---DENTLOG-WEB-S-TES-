using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_PROJE.ViewComponents.Blog
{
    public class Son3Blog : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.son3Blogs();

            return View(values);
        }

    }
}
