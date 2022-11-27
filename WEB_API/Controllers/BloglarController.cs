using BussinessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloglarController : ControllerBase
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());

        [HttpGet]

        public IActionResult BloglarListele()
        {
            return Ok(bm.listBlogs());
        }

        [HttpPost]
        public IActionResult BloglarEkle([FromBody] Blog Blog)
        {
            bm.EkleBlog(Blog);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult BloglarSil(int id)
        {
            var deger = bm.SinifGetirBlog(id);

            if (deger == null)
            {
                return NotFound();
            }
            bm.SilBlog(deger);

            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult BlogGetir(int id)
        {
            var sinif = bm.SinifGetirBlog(id);

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
        public IActionResult BloglarGuncelleApi(Blog Blog)
        {
            var sinif = bm.SinifGetirBlog(Blog.BlogID);

            if (sinif == null)
            {
                return NotFound();
            }
            else
            {
                bm.GuncelleBlog(Blog);
                return Ok();
            }

        }


    }
}
