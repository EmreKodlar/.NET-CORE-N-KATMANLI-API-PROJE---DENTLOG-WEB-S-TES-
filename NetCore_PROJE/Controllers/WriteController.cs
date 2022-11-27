using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;

using System.Text;
using System.Threading.Tasks;

namespace NetCore_PROJE.Controllers
{
    public class WriteController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());


        public IActionResult Upload()
        {
            return View();
        }


        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> WriterShow()
        {

            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:5001/api/yazarlar");
            var jsonString = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ClassWrite>>(jsonString);
            return View(values.Where(x => x.WriterStatus == true));

        }

        [AllowAnonymous]
        public IActionResult WriterGetir(int id)
        {
            var yazar = wm.SinifGetirWriter(id);
            ViewBag.YazarAd = yazar.WriterName;
            ViewBag.Yazarhak = yazar.WriterAbout;
            return View(bm.BlogKategoriYorumListesiAL().FindAll(x => x.WriterID == id));

        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> IndexWrite()
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();


            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:5001/api/yazarlar");
            var jsonString = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ClassWrite>>(jsonString);
            return View(values);

        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> WriterEklemeYeri(ClassWrite writer) // Api ile ekleme
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();
            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();
            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            //----yenisi resim ekleme------
            if (writer.WriterImage != null) // resim dosyası seçili ise
            {
                string imageExtension = Path.GetExtension(writer.WriterImage.FileName); // resim uzantısı
                string imageName = Guid.NewGuid() + imageExtension; // resim adı
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}"); // resim yolu
                using (var image = Image.Load(writer.WriterImage.OpenReadStream()))
                {
                    string newSize = ResizeImageW(image, 300, 300); // boyutlandırma boyutu
                    string[] aSize = newSize.Split(',');
                    image.Mutate(h => h.Resize(Convert.ToInt32(aSize[1]), Convert.ToInt32(aSize[0])));
                    image.Save(path);
                }
                writer.WriterImageName = imageName; //veri tabanına eklenecek kısım
                writer.WriterImage = null; //BURASI ÇOK ÖNEMLİ! 
                // writer.WriterImage = null; YAPILMAZSA DB'YE KAYIT ETMİYOR. ÇÜNKÜ ONU DA KAYDETMEYE ÇALIŞIYOR...
            }
            else { writer.WriterImageName = "kedi.jpg"; }// dosya eklenmemişse kedi resmi yükle

            //--------şifreyi kriptolama-------------------------
 
            writer.WriterPassword = MD5Sifreleme(writer.WriterPassword);

            //---------------------------------------------------


            //----------------------------------------------------------------------------------
            var client = new HttpClient(); // Client olarak bağlan
            var jsonWriter = JsonConvert.SerializeObject(writer);// gelen veriyi Json'a çevir
            StringContent content = new StringContent(jsonWriter, Encoding.UTF8, "application/json"); // json yaptığın gelen veriyi content olarak tanımla
            var response = await client.PostAsync("https://localhost:5001/api/yazarlar", content); // content'i bu api'ye post et
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("IndexWrite");
            }
            return NotFound();
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> WriterDelete(int id)
        {

            var yazarGelsin = wm.SinifGetirWriter(id);

            //---eski resmi dosyadan silme
            var path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", yazarGelsin.WriterImageName);

            if (System.IO.File.Exists(path2) && yazarGelsin.WriterImageName!="kedi.jpg")
            {
                System.IO.File.Delete(path2); // sil
            }

            //--------------oOo-------------------

            //---api ile silme işlemi---------------------
            var client = new HttpClient();
            var response = await client.DeleteAsync("https://localhost:5001/api/yazarlar/" + id); // bu id'li parametresi sil
            //--------------oOo-------------------

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("IndexWrite");
            }

            return RedirectToAction("IndexWrite");
        }

        [HttpGet]
        public IActionResult WriterProfile()
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            return View(wm.SinifGetirWriter(Convert.ToInt32(ViewBag.Writer_ID)));

        }

        [HttpPost]
        public IActionResult WriterProfile(Writer writer)
        {

            //---eski resmi dosyadan silme

            var sinifEski = wm.SinifGetirWriter(writer.WriterID); //  güncellemeden önceki DB'den resim yolunu almak için...

            if (sinifEski.WriterImageName != null && writer.WriterImage != null)
            {
                var path22 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", sinifEski.WriterImageName);

                if (System.IO.File.Exists(path22))
                {
                    System.IO.File.Delete(path22); // sil
                }
            }

            //--------------oOo-------------------

            //----yenisini ekleme------

            if (writer.WriterImage != null) // resim dosyası seçili ise
            {

                string imageExtension = Path.GetExtension(writer.WriterImage.FileName); // resim uzantısı

                string imageName = Guid.NewGuid() + imageExtension; // resim adı

                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}"); // resim yolu

                using (var image = Image.Load(writer.WriterImage.OpenReadStream()))
                {
                    string newSize = ResizeImageW(image, 300, 300); // boyutlandırma boyutu
                    string[] aSize = newSize.Split(',');
                    image.Mutate(h => h.Resize(Convert.ToInt32(aSize[1]), Convert.ToInt32(aSize[0])));
                    image.Save(path);
                }
                writer.WriterImageName = imageName; //veri tabanına eklenecek kısım

            }
            else
            {
                writer.WriterImageName = sinifEski.WriterImageName; // dosya eklenmemişse eskisini yükle
            }
            //--------------------------
            writer.WriterStatus = sinifEski.WriterStatus;
            wm.GuncelleWriter(writer);

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            TempData["WriterMesaj"] = "Tebrikler Güncellemeleriniz Yapıldı . Değişikliklerin aktif olması için ÇIKIŞ yapıp tekrar giriniz!";

            return View(wm.SinifGetirWriter(Convert.ToInt32(ViewBag.Writer_ID)));

        }
        public string ResizeImageW(Image img, int maxWidth, int maxHeight)
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

        [HttpGet]
        public IActionResult WriterPassword()
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();


            return View(wm.SinifGetirWriter(Convert.ToInt32(ViewBag.Writer_ID)));

        }


        [HttpPost]
        public IActionResult WriterPassword(Writer writer)
        {
            var sinifGetir = wm.SinifGetirWriter(writer.WriterID);

            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();

            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();

            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();


            var yeniSifre = Request.Form["YeniSifre"];
            writer.WriterPassword = MD5Sifreleme(writer.WriterPassword);
            yeniSifre = MD5Sifreleme(yeniSifre);

            if (sinifGetir.WriterPassword != writer.WriterPassword)
            {
                TempData["WriterMesaj"] = "İşlem BAŞARISIZ! Eski Şifreniz Hatalı!";

                return View(wm.SinifGetirWriter(Convert.ToInt32(ViewBag.Writer_ID)));
            }

            else if (yeniSifre == writer.WriterPassword)
            {
                TempData["WriterMesaj"] = "İşlem BAŞARISIZ! Yeni Şifre Eski Şifreyle Aynı Olamaz!";

                return View(wm.SinifGetirWriter(Convert.ToInt32(ViewBag.Writer_ID)));
            }

            else
            {

                writer.WriterPassword = yeniSifre;
                writer.WriterStatus = sinifGetir.WriterStatus;

                wm.GuncelleWriter(writer);

                TempData["WriterMesaj"] = "İşlem BAŞARILI! Tebrikler Şifreniz Değişti. Lütfen Şifrenizi Not Ediniz!";

                return View(wm.SinifGetirWriter(Convert.ToInt32(ViewBag.Writer_ID)));
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> WriterUpdate(int id)
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();
            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();
            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:5001/api/yazarlar/" + id); // bu id'ye ait jSon verisini al

            if (response.IsSuccessStatusCode)
            {
                var JsonString = await response.Content.ReadAsStringAsync();
                var gelenVeri = JsonConvert.DeserializeObject<ClassWrite>(JsonString);
                return View(gelenVeri);
            }
            else
            {
                return NotFound();
            }
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> WriterUpdate(ClassWrite write)
        {
            //---eski resmi dosyadan silme
            var sinifEski = wm.SinifGetirWriter(write.WriterID); //  güncellemeden önceki DB'den resim yolunu almak için...
            if (sinifEski.WriterImageName != null && write.WriterImage != null)
            {
                var path22 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", sinifEski.WriterImageName);
                if (System.IO.File.Exists(path22))
                {
                    if (sinifEski.WriterImageName != "kedi.jpg") { System.IO.File.Delete(path22); } // sil 
                }
            }
            //----yenisini ekleme------
            if (write.WriterImage != null) // resim dosyası seçili ise
            {
                string imageExtension = Path.GetExtension(write.WriterImage.FileName); // resim uzantısı
                string imageName = Guid.NewGuid() + imageExtension; // resim adı
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}"); // resim yolu
                using (var image = Image.Load(write.WriterImage.OpenReadStream()))
                {
                    string newSize = ResizeImageW(image, 300, 300); // boyutlandırma boyutu
                    string[] aSize = newSize.Split(',');
                    image.Mutate(h => h.Resize(Convert.ToInt32(aSize[1]), Convert.ToInt32(aSize[0])));
                    image.Save(path);
                }
                write.WriterImageName = imageName; //veri tabanına eklenecek kısım
                write.WriterImage = null; //veritabanında böyle bir alan yok o yüzden null dönmeli
            }
            else
            {
                write.WriterImageName = sinifEski.WriterImageName; // dosya eklenmemişse eskisini yükle
            }
            //----Esas async işlem burdan başlıyor
            var client = new HttpClient();
            var gelenVeri = JsonConvert.SerializeObject(write);
            var content = new StringContent(gelenVeri, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:5001/api/yazarlar/", content); // contenti gönder

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("IndexWrite");
            }
            else
            {
                return NotFound();
            }
        }

        public string MD5Sifreleme(string sifre) // Şifreleme
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifre);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
    }

     
    public class ClassWrite
    {
        [Key]
        public int WriterID { get; set; }

        public string WriterName { get; set; }

        public string WriterAbout { get; set; }

        [NotMapped]
        public IFormFile WriterImage { get; set; }

        public string WriterImageName { get; set; }

        public string WriterMail { get; set; }

        public string WriterPassword { get; set; }

        public bool WriterStatus { get; set; }

    }

} 
