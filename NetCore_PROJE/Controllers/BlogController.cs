using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NetCore_PROJE.Controllers
{ 
    public class BlogController : Controller
    { 

        BlogManager bm = new BlogManager(new EfBlogRepository());

        CategoryManager catm = new CategoryManager(new EfCategoriesRepository());

        CommentManager cm = new CommentManager(new EfCommentRepository());

        WriterManager wm = new WriterManager(new EfWriterRepository());

        [AllowAnonymous]
        public IActionResult IndexBlog() 
        {
            return View(bm.BlogKategoriYorumListesiAL().OrderByDescending(x => x.BlogID)); // Kategori ve yorumla beraber gelen fonksiyonu çağırdık
        }
        [Route("Blog/BlogDetails/{id}/{title}")]
        [AllowAnonymous]
        [HttpGet]
        public IActionResult BlogDetails(int id)
        {
            var gelenBlog = bm.SinifGetirBlog(id);
 
            ViewBag.yorumSirala = cm.listComments(id).Where(x=>x.CommentStatus==true);

            return View(gelenBlog); 
        }

        [AllowAnonymous]
        public PartialViewResult BlogSirala()
        {
            return PartialView(bm.listBlogs());
        }

        
        public IActionResult WriterBlogs()
        {
            //Claim ile id, name ve maili aldık. Ve onları Viewbag'lere atarak .cshtml sayfaya taşıdık.
            //Session değerlerini taşımak için diğer action'lara da bunu yapmamız gerekiyor!!!

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();
 
            var writerBlogYazilariGetir = bm.GetBlogListWithWritter(Convert.ToInt32(ViewBag.Writer_ID)); //ID'yi int'e çevirip koyduk ;)            

            return View(writerBlogYazilariGetir);
        }

        public IActionResult BlogSil(int id)
        {


            var blogg = bm.SinifGetirBlog(id);


            //---eski resmi dosyadan silme
            var path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", blogg.BloglImageName);

            if (System.IO.File.Exists(path2))
            {
                System.IO.File.Delete(path2); // sil
            }

            //--------------oOo-------------------


            bm.SilBlog(blogg);
            TempData["mesaj"] = "Tebrikler Başarıyla Sildiniz...";
            return RedirectToAction("WriterBlogs");
        }


        [HttpGet]
        public IActionResult NewBlog()
        {
            ViewBag.kategoriler = new SelectList(catm.listCategories(), "CategoryID", "CategoryName");

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            KategoriVeBlog mymodel = new KategoriVeBlog(); //mecbur new'leyeceğiz...
            mymodel.Categories = catm.listCategories(); // modelimizin içine at
            mymodel.Blogs = bm.listBlogs(); // modelimizin içine at
              
            return View(mymodel);
             
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult BlogSearch()
        {
            string kelime = Request.Form["Search"];
            return View(bm.GetBlogListWithSearch(kelime));
        }

        [HttpPost]
        public  IActionResult  NewBlog(Blog blog)
        {
            //--.netCore ile reSİM eKLEME İŞLEMLERİ--- not: image klasörünü wwwroot içine ekle

             if (blog.BloglImage != null) // resim dosyası seçili ise
             {

                string imageExtension = Path.GetExtension(blog.BloglImage.FileName); // resim uzantısı

                string imageName = Guid.NewGuid() + imageExtension; // resim adı + uzantısı

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}"); // resim yolu

                //using var stream = new FileStream(path, FileMode.Create); 

                //await blog.BloglImage.CopyToAsync(stream);
                 
                using (var image = Image.Load(blog.BloglImage.OpenReadStream()))
                {
                    string newSize = ResizeImage(image, 720, 720); // boyutlandırma boyutu
                    string[] aSize = newSize.Split(',');
                    image.Mutate(h => h.Resize(Convert.ToInt32(aSize[1]), Convert.ToInt32(aSize[0])));
                    image.Save(path);
                }
                  blog.BloglImageName = imageName; //veri tabanına eklenecek kısım

            }
             else
            {
                blog.BloglImageName = "kedi.jpg";
            }
            //---------------------------
            bm.EkleBlog(blog);
            TempData["mesaj"] = "Tebrikler Yeni Bloğu Başarıyla Eklediniz...";
            return RedirectToAction("WriterBlogs");
        }

        [HttpGet]
        public IActionResult BlogDuzenle(int id)
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            var bilgiler = bm.SinifGetirBlog(id);

            ViewBag.kategoriler = new SelectList(catm.listCategories(), "CategoryID", "CategoryName", bilgiler.CategoryID);

            return View(bilgiler);
        }

        [HttpPost]
        public IActionResult BlogDuzenle(Blog blog)
        {

            bm.GuncelleBlog(blog);
            TempData["mesaj"] = "Tebrikler Başarıyla Düzenlediniz...";
            return RedirectToAction("WriterBlogs");
        }

        [HttpPost]
        public IActionResult BlogDuzenleFoto(Blog blog)
        {
            //---eski resmi dosyadan silme

            var sinifEski = bm.SinifGetirBlog(blog.BlogID); //  güncellemeden önceki resim yolunu almak için...
 
            var path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", sinifEski.BloglImageName);

            if (System.IO.File.Exists(path2))
            {
                System.IO.File.Delete(path2); // sil
            }
 
            //--------------oOo-------------------

            //----yenisini ekleme------

            if (blog.BloglImage != null) // resim dosyası seçili ise
            {

                string imageExtension = Path.GetExtension(blog.BloglImage.FileName); // resim uzantısı

                string imageName = Guid.NewGuid() + imageExtension; // resim adı

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}"); // resim yolu

                //using var stream = new FileStream(path, FileMode.Create);

                //await blog.BloglImage.CopyToAsync(stream);

                using (var image = Image.Load(blog.BloglImage.OpenReadStream()))
                {
                    string newSize = ResizeImage(image, 730, 730); // boyutlandırma boyutu
                    string[] aSize = newSize.Split(',');
                    image.Mutate(h => h.Resize(Convert.ToInt32(aSize[1]), Convert.ToInt32(aSize[0])));
                    image.Save(path);
                }
                blog.BloglImageName = imageName; //veri tabanına eklenecek kısım
 

            }
            else
            {
                blog.BloglImageName = "kedi.jpg";
            }
            //--------------------------

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            bm.GuncelleBlog(blog);

            TempData["mesaj"] = "Tebrikler Resmi Başarıyla Güncellediniz...";

            return RedirectToAction("WriterBlogs");
        }

        public string ResizeImage(Image img, int maxWidth, int maxHeight)
        {
            if(img.Width>maxWidth || img.Height > maxHeight)
            { 
            double widthRatio = (double)img.Width / (double)maxWidth;
            double heightRatio = (double)img.Height / (double)maxHeight;
            double ratio = Math.Max(widthRatio, heightRatio);
            int newWidth = (int)(img.Width / ratio);
            int newHeight = (int)(img.Height / ratio);
            return newHeight.ToString() + "," + newWidth.ToString();
            }
             else
            {
                return img.Height.ToString() + "," + img.Width.ToString();
            }
        }
    }
}
