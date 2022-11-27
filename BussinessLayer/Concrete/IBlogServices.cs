using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Concrete
{
    public interface IBlogServices
    {
        List<Blog> listBlogs();

        List<Blog> son3Blogs();

        void EkleBlog(Blog cat);
        void SilBlog(Blog cat);
        void GuncelleBlog(Blog cat);
        Blog SinifGetirBlog(int id);

        List<Blog> GetBlogListWithCategory();

        List<Blog> GetBlogByID(int id);

        List<Blog> GetBlogListWithWritter(int id);

        List<Blog> BlogKategoriYorumListesiAL();

        int BlogSayisi(int kategoriID);
         



    }
}
