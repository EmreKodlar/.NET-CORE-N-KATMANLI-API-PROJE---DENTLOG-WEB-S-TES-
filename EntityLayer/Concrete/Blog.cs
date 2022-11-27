using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        public string BlogTitle { get; set; }


        public string BlogContent { get; set; }
 

        public string BloglImageName { get; set; } //dosyanın veritabanına yazılacak isim

        [NotMapped] // dosyanın kendisini Bayt cinsinden veritabnına eklemeyi engeller
        public IFormFile BloglImage { get; set; } //dosyanın kendisi

        public string BlogCreateContent { get; set; }

        public bool BlogStatus { get; set; }

       
        // İlişkisel veritabanı için

        public int CategoryID { get; set; } // Kategori ID'si alacak.

        public Category Category { get; set; }

        public int WriterID { get; set; } // Writer ID'si alacak.

        public Writer Writer { get; set; }

        public List<Comment> Comment { get; set; } // Comments'e ID verecek. 

        public int CommentCount { get; set; }
    }
}
