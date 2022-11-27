using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WEB_API.Controllers
{
    public class CreateToken
    {

        WriterManager wm = new WriterManager(new EfWriterRepository());
       
        public string BuildToken( int id, string name) {

            var sinif = wm.SinifGetirWriter(id); //sınıf üret

            //--- Authentication(Yetkilendirme) başarılı ise JWT token üretilir.----
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("emre çiftçi şifre 08041987");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.SerialNumber, sinif.WriterID.ToString()), // id aldık
                    new Claim(ClaimTypes.Name, name), // ismi aldık
                    new Claim(ClaimTypes.Email, sinif.WriterImageName),  // fotosunu aldık      
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);


            return tokenHandler.WriteToken(token);

            //var bytes = Encoding.UTF8.GetBytes(_configuration["Token: SecurityKey"]); //startup da vetrdiğimiz key değeri
            //SymmetricSecurityKey key = new SymmetricSecurityKey(bytes); // baytı key'e aktar
            //SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256); // baytı HS256'ya göre kriptola
            //JwtSecurityToken token = new JwtSecurityToken(issuer: _configuration["Token: Issuer"], audience: _configuration["Token: Audience"],
            //notBefore: DateTime.Now, expires: DateTime.Now.AddDays(1), signingCredentials: credentials); // token güvenlik parametreleri
            ////sırayla->oluşturan, kullananan, token başlanagıcı, token süresi, credentials'i
            //JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler(); // token oluşturucuyu türet
            //return handler.WriteToken(token); // ve oluşturucu yardımıyla token'ı yaz ...
        }

    }
}
