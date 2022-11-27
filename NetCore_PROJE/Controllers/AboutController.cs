using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager( new EfAboutRepository());

        [AllowAnonymous]
        public IActionResult IndexAbout()
        {

            return View(abm.SinifGetirAbout(2));
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AboutUpdate()
        {

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            return View(abm.SinifGetirAbout(2));
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {

            //---eski resmi dosyadan silme

            var sinifEski = abm.SinifGetirAbout(about.AboutID); //  güncellemeden önceki DB'den resim yolunu almak için...

            if (sinifEski.AboutImageName != null && about.AboutImage != null)
            {
                var path22 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", sinifEski.AboutImageName);

                if (System.IO.File.Exists(path22))
                {
                    System.IO.File.Delete(path22); // sil
                }
            }

            //--------------oOo-------------------

            //----yenisini ekleme------

            if (about.AboutImage != null) // resim dosyası seçili ise
            {

                string imageExtension = Path.GetExtension(about.AboutImage.FileName); // resim uzantısı

                string imageName = Guid.NewGuid() + imageExtension; // resim adı

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}"); // resim yolu

                using (var image = Image.Load(about.AboutImage.OpenReadStream()))
                {
                    string newSize = ResizeImageA(image, 400, 400); // boyutlandırma boyutu
                    string[] aSize = newSize.Split(',');
                    image.Mutate(h => h.Resize(Convert.ToInt32(aSize[1]), Convert.ToInt32(aSize[0])));
                    image.Save(path);
                }
                about.AboutImageName = imageName; //veri tabanına eklenecek kısım

            }
            else
            {
                about.AboutImageName = sinifEski.AboutImageName; // dosya eklenmemişse eskisini yükle
            }
            //--------------------------
             
            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            TempData["AboutMesaj"] = "Tebrikler Güncellemeleriniz Yapıldı...";

            abm.GuncelleAbout(about);

            return View(abm.SinifGetirAbout(2));

        }
        public string ResizeImageA(Image img, int maxWidth, int maxHeight)
        {
            if (img.Width > maxWidth || img.Height > maxHeight)
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
