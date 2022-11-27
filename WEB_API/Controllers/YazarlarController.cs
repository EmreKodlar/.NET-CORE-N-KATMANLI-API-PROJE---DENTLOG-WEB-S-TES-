using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    [Route("api/[controller]")]
    [ApiController]
    public class YazarlarController : ControllerBase
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet("{id}/{name}")]
        public IActionResult TokenGetir(int id, string name)
        {
            return Ok(new CreateToken().BuildToken(id,name));
        }

        [HttpGet]
        public IActionResult YazarListele()
        {
            return Ok(wm.listWriters());
        }

        
        [HttpPost]
        public IActionResult YazarEkle([FromBody] Writer writer)
        {
            wm.EkleWriter(writer);
            return Ok();
        }

         
        [HttpDelete("{id}")]
        public IActionResult YazarSil(int id)
        {
            var deger=wm.SinifGetirWriter(id);

            if (deger == null)
            {
                return NotFound();
            }
            wm.SilWriter(deger);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult YazarGetir(int id)
        {
            var sinif = wm.SinifGetirWriter(id);

            if (sinif == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(sinif);
            }
            
        }
         
        [HttpPut]
        public IActionResult YazarGuncelleApi([FromBody] Writer writer)
        {
            var sinif = wm.SinifGetirWriter(writer.WriterID);

            if (sinif == null)
            {
                return NotFound();
            }
            else
            {
                wm.GuncelleWriter(writer);
                return Ok();
            }

        }

    }
}
