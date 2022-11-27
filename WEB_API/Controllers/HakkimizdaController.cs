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
    public class HakkimizdaController : ControllerBase
    {

        AboutManager abm = new AboutManager(new EfAboutRepository());

        [HttpGet]
        public IActionResult HakkimizdaGetir()
        {
            var sinif = abm.SinifGetirAbout(2);

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
        public IActionResult HakkimizdaGuncelleApi(About about)
        {
            var sinif = abm.SinifGetirAbout(2);

            if (sinif == null)
            {
                return NotFound();
            }
            else
            {
                abm.GuncelleAbout(about);
                return Ok();
            }

        }
    }
}
