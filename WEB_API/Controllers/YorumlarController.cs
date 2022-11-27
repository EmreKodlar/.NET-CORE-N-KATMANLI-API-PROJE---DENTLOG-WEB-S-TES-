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
    public class YorumlarController : ControllerBase
    {
        CommentManager com = new CommentManager(new EfCommentRepository());

        [HttpGet]
        public IActionResult YorumlariGetir()
        {
            return Ok(com.listeleComments());
        }

        [HttpPost]
        public IActionResult YorumEkle([FromBody] Comment comment)
        {
            com.EkleComment(comment);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult YorumSil(int id)
        {
            var deger = com.SinifGetirComment(id);

            if (deger == null)
            {
                return NotFound();
            }
            com.SilComment(deger);

            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult YorumGetir(int id)
        {
            var sinif = com.SinifGetirComment(id);

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
        public IActionResult YazarGuncelleApi(Comment comment)
        {
            var sinif = com.SinifGetirComment(comment.CommentID);

            if (sinif == null)
            {
                return NotFound();
            }
            else
            {
                com.GuncelleComment(comment);
                return Ok();
            }

        }


    }
}
