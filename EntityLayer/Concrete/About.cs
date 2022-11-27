using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }

        [NotMapped]
        public IFormFile AboutImage { get; set; }
        public string AboutImageName { get; set; }
        //public string AboutMapLocation { get; set; }
        //public bool AboutStatus { get; set; }
    }
}
