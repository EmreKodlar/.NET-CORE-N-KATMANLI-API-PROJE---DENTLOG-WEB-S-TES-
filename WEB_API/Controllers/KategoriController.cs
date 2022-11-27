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
    public class KategoriController : ControllerBase
    {

        CategoryManager cm = new CategoryManager(new EfCategoriesRepository()); // Controller tarafındaki tanımlama

        BlogManager bm = new BlogManager(new EfBlogRepository());

        [HttpGet]
        public IActionResult KategoriListele()
        {

            return Ok(cm.listCategories());
        }

        [HttpPost]
        public IActionResult KategoriEkle([FromBody] Category category)
        {
            cm.EkleCategory(category);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult KategoriSil(int id)
        {
            var deger = cm.SinifGetirCategory(id);

            if (deger == null)
            {
                return NotFound();
            }
            cm.SilCategory(deger);

            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult KategoriGetir(int id)
        {
            var sinif = cm.SinifGetirCategory(id);

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
        public IActionResult KategoriGuncelleApi(Category category)
        {
            var sinif = cm.SinifGetirCategory(category.CategoryID);

            if (sinif == null)
            {
                return NotFound();
            }
            else
            {
                cm.GuncelleCategory(category);
                return Ok();
            }

        }

    }
}
