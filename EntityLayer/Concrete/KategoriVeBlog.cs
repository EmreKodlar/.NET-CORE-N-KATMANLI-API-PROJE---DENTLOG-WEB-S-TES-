using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityLayer.Concrete
{
    public class KategoriVeBlog : Blog
    {

        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }

         
        public new int CategoryID;

        public string CategoryName;



    }
}
