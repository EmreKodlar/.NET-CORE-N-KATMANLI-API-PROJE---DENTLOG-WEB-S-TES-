using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
 

namespace NetCore_PROJE.Controllers
{ 
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        BlogManager bm = new BlogManager(new EfBlogRepository());

        [AllowAnonymous]
        [HttpPost]
        public IActionResult CommentAddBlog(Comment c)
        {
            c.CommentDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy HH:mmm:ss")); // Mssql DateTime formatı
            c.CommentStatus = false;

            var remoteIpAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();

            c.CommentIPadress = remoteIpAddress;
            cm.EkleComment(c);
  
            //----------------/güvenli mail gönderme/----------------------------------------
             
            string username = "tasarim.emre.ciftci@gmail.com"; // BU MAİL ÜZERİNDEN İLETİŞİM SAĞLANACAK
            string password = "nyhwihzjlangbhlv"; // bu şifre  https://myaccount.google.com/apppasswords da oluşturulan şifre ;) Bunun için önce GMAİL 2 adımlı doğrulamayı etkinleştir.
            ICredentialsByHost credentials = new NetworkCredential(username, password);

            SmtpClient smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = credentials
            }; 

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("sedefyesildag0@gmail.com"); // maili gönderen kim?
            mail.To.Add(username); // mail kime gidecek? Alıcı Kısmı
            mail.Subject = "Dentlog Web Sitesinde Bir Yorum Yapıldı";
            mail.Body = c.CommentUserName + "<br />" + c.CommentTitle + "<br />" + c.CommentContent + "<br />IP: " + c.CommentIPadress + "<br />Blog No: " + c.BlogID;
            mail.IsBodyHtml = true;
            smtpClient.Send(mail);

            //----------------------------------------------------------------


            return RedirectToAction("BlogDetails","Blog", new { id = c.BlogID });
        }
        [AllowAnonymous]
        public PartialViewResult ListCommentAtBlog(int id)
        {
            var values = cm.listComments(id).Where(x=>x.CommentStatus==true);
            return PartialView(values);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> IndexComment()
        {
            ViewBag.Writer_Name = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Name).Value.ToString();
            ViewBag.Writer_Mail = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.Email).Value.ToString();
            ViewBag.Writer_ID = ((ClaimsIdentity)User.Identity).FindFirst(ClaimTypes.SerialNumber).Value.ToString();

            var client = new HttpClient();
            var response = await client.GetAsync("https://localhost:5001/api/yorumlar");
            var jsonString = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<CommentClass>>(jsonString);
            return View(values);

        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> CommentSil(int id)
        {

            var yazarGelsin = cm.SinifGetirComment(id);

            //---blog taki CommentCount 1 azalsın---

            var blogSinif = bm.SinifGetirBlog(yazarGelsin.BlogID);

            blogSinif.CommentCount = blogSinif.CommentCount - 1;
 
            bm.GuncelleBlog(blogSinif);

            //--------------oOo---------------------

            //---api ile silme işlemi---------------------
            var client = new HttpClient();
            var response = await client.DeleteAsync("https://localhost:5001/api/yorumlar/" + id); // bu id'li parametresi sil
                                                                                                  //--------------oOo-------------------

            TempData["mesaj"] = "Silme İşlemi Yapıldı...";

            return RedirectToAction("IndexComment");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> CommentDurum(int id)
        {

            var comment = cm.SinifGetirComment(id);

            comment.CommentStatus = !comment.CommentStatus; // statusu tersine çevir...


            //---------blog daki sayıyı 1 arttır ya da 1 azalt----------
            var sinif = bm.SinifGetirBlog(comment.BlogID);

            if (comment.CommentStatus==true)
            sinif.CommentCount = sinif.CommentCount + 1;
            else
            sinif.CommentCount = sinif.CommentCount - 1;


            bm.GuncelleBlog(sinif);
            //--------------------------------------------

            //----Esas async işlem burdan başlıyor
            var client = new HttpClient();
            var gelenVeri = JsonConvert.SerializeObject(comment);
            var content = new StringContent(gelenVeri, Encoding.UTF8, "application/json");
            var response = await client.PutAsync("https://localhost:5001/api/yorumlar/", content); // contenti gönder

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("IndexComment");
            }
            else
            {
                return NotFound();
            }
        }

    }
     
    public class CommentClass
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public string CommentIPadress { get; set; }

        //İlişkisel veritabanı

        public int BlogID { get; set; }

        public Blog Blog { get; set; }
    }

}
