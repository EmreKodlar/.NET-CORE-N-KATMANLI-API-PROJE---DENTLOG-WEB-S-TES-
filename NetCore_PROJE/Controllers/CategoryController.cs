using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
 

namespace NetCore_PROJE.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager cm = new CategoryManager(new EfCategoriesRepository()); // Controller tarafındaki tanımlama

        BlogManager bm = new BlogManager(new EfBlogRepository());
        
        [Authorize(Roles = "Admin")]
        public IActionResult IndexCategory()
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            return View(cm.listCategories()); // Manager'daki fonksiyonu alabiiyoruz
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult NewCategory(Category category)
        {
            cm.EkleCategory(category);

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            return RedirectToAction("IndexCategory");

        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            return View(cm.SinifGetirCategory(id));
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            cm.GuncelleCategory(category);

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            return RedirectToAction("IndexCategory");

        }
        [AllowAnonymous]
        public IActionResult CategoryShow()
        {
            KategoriVeBlog mymodel = new KategoriVeBlog(); //mecbur new'leyeceğiz...
            mymodel.Categories = cm.listCategories(); // modelimizin içine at
            mymodel.Blogs = bm.listBlogs(); // modelimizin içine at

            return View(mymodel);
        }
        [AllowAnonymous]
        public IActionResult KategoriGetir(int id)
        {
            var kategori = cm.SinifGetirCategory(id);

            ViewBag.KategoriAd = kategori.CategoryName;
            
            return View(bm.BlogKategoriYorumListesiAL().FindAll(x=>x.CategoryID==id));

        }



    }
}
