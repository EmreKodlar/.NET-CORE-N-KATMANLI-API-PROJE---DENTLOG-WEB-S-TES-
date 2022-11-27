using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_PROJE.Views.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCategoriesRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            KategoriVeBlog mymodel = new KategoriVeBlog(); //mecbur new'leyeceğiz...
            mymodel.Categories = cm.listCategories(); // modelimizin içine at
            mymodel.Blogs = bm.listBlogs(); // modelimizin içine at

            return View(mymodel);

             
        }

    }
}
