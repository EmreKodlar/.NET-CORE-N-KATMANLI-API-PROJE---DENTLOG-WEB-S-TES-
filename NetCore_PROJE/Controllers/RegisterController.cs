using BussinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WEB_API.Controllers;

namespace NetCore_PROJE.Controllers
{

    [AllowAnonymous] // buraya eklersen tüm controlleri etkiler. İstersen ayrı ayrı actionlara da yazabilirsin
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        WriteController wc = new WriteController();

        YazarlarController yc = new YazarlarController();
 

        [HttpGet]
        public IActionResult IndexRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IndexRegister(Writer p)
        {
            p.WriterStatus = false;

            p.WriterPassword = "1234dent";

            p.WriterImageName = "kedi.jpg";

            wm.EkleWriter(p);

            TempData["mesaj"] = "Bilgileriniz editörlerimizce incelenecektir.";

            return View();
        }

        [HttpGet]
        public IActionResult IndexSignIn()
        {
             
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> IndexSignIn(Writer p)
        {

            p.WriterPassword=wc.MD5Sifreleme(p.WriterPassword); // Kullanıcının girdiği şifreyi tekrar MD5'e çevir.
            // DB içerisinde de Md5'li hali olduğu için zaten 2'sini karşılaştırmış olacak...
            //Bu sayede kullanıcıdan başka hiç kimse şifrelere erişemeyecek...

            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault( x =>x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword && x.WriterStatus==true); //2. de x=> işareti kullanma

            if (datavalue != null)
            {

                if (datavalue.WriterImageName == null)
                {
                    datavalue.WriterImageName = "defaultProImage.png";
                }

                //-------bu kısım claims ile giriş yapma kodları---------
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.SerialNumber, datavalue.WriterID.ToString()), // id aldık
                    new Claim(ClaimTypes.Name, datavalue.WriterName), // ismi aldık
                    new Claim(ClaimTypes.Email, datavalue.WriterImageName),  // fotosunu aldık                                                            
                };

                var useridentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                //----------- Rol ile Yetki atamalarını veriyoruz ------------------

                if (datavalue.WriterID == 1)
                {
                    useridentity.AddClaim(new Claim(ClaimTypes.Role, "Admin")); // Role Atamasını yapıyoruz.
                }
                //----------------------------------------------------------------

                var auth = new AuthenticationProperties
                {

                    ExpiresUtc = System.DateTimeOffset.UtcNow.AddDays(60), // kaç gün sonra cookiler kapansın

                };
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal, auth);
                //--------------------------------------------------------
           
                    @ViewData["yazarNo"] = datavalue.WriterID.ToString(); // view kısmındaki linkleri gizlemek için...
                 
                    return RedirectToAction("WriterBlogs", "Blog");
             
            }
            else
            {
                TempData["error"] = "Hatalı Giriş Yaptınız! Tekrar Deneyiniz...";
                return RedirectToAction("IndexSignIn", "Register");
            }
            
        }

        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("IndexSignIn","Register");
        }
 
    }

    public class Tokens
    {
        public string Token { get; set; }
        //public string RefreshToken { get; set; }
    }



}
