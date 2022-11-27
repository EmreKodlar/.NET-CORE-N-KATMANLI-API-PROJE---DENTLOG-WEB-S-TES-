using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_PROJE.Controllers
{
    public class CkeEditorImageController : Controller
    { 
        [HttpPost] 
        public IActionResult UploadImage(IFormFile upload)
        {
            if (upload != null) // resim dosyası seçili ise
            {
                string imageExtension = Path.GetExtension(upload.FileName); // resim uzantısı
                string imageName = Guid.NewGuid() + imageExtension; // resim adı
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}"); // resim yolu
                using (var image = Image.Load(upload.OpenReadStream()))
                {
                    string newSize = ResizeImageCKE(image,700,700); // boyutlandırma fonksiyonu
                    string[] aSize = newSize.Split(',');
                    image.Mutate(h => h.Resize(Convert.ToInt32(aSize[1]), Convert.ToInt32(aSize[0])));
                    image.Save(path);
                } 
                var url = $"{"/images/"}{imageName}"; // JSON olarak gidecek kısım -> wwwroot ekleme!
                return Json(new { uploaded = true, url }); // gönder
            }
                return null;
        }
        public string ResizeImageCKE(Image img, int maxWidth, int maxHeight) // boyutlandırma fonksiyonu
        {
            if (img.Width > maxWidth || img.Height > maxHeight)
            {   double widthRatio = (double)img.Width / (double)maxWidth;
                double heightRatio = (double)img.Height / (double)maxHeight;
                double ratio = Math.Max(widthRatio, heightRatio);    int newWidth = (int)(img.Width / ratio); 
                int newHeight = (int)(img.Height / ratio);  return newHeight.ToString() + "," + newWidth.ToString();
            }
            else
            { return img.Height.ToString() + "," + img.Width.ToString(); }
        }

    }
}
