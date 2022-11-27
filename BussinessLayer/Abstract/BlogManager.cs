using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLayer.Abstract
{
    public class BlogManager : IBlogServices
    {
        IBlogDal _iBlogDal; // Önce tanımla 

        public BlogManager(IBlogDal iBlogDal)
        {
            _iBlogDal = iBlogDal; // sonra  new'lemeden interface'i ata! Artık tüm Generic metotlar bunun içinde.
        }

        public void EkleBlog(Blog cat)
        {
            _iBlogDal.Add(cat);
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _iBlogDal.SartliListele(x=>x.BlogID==id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _iBlogDal.ListWithCategory();
        }

        public List<Blog> GetBlogListWithCategoryID(int id)
        {
            return _iBlogDal.SartliListele(x => x.CategoryID == id);
        }

        public List<Blog> GetBlogListWithSearch(string kelime)
        {
            return _iBlogDal.listAll().Where(x => x.BlogTitle.Contains(kelime, StringComparison.OrdinalIgnoreCase)).ToList();
        }


        public List<Blog> GetBlogListWithWritter(int id)
        {
            return _iBlogDal.SartliListele(x => x.WriterID == id);
        }

        public List<Blog> BlogIDileYazarinSon5Yazisi(int id)
        {
            var nesne= SinifGetirBlog(id);

            return _iBlogDal.SartliListele(x => x.WriterID == nesne.WriterID).TakeLast(5).ToList(); ;
        }

        public void GuncelleBlog(Blog cat)
        {
            _iBlogDal.Update(cat);
        }

        public List<Blog> listBlogs()
        {
            return _iBlogDal.listAll();
        }

        public void SilBlog(Blog cat)
        {
            _iBlogDal.Delete(cat);
        }

        public Blog SinifGetirBlog(int id)
        {
            return _iBlogDal.getByID(id);
        }

        public List<Blog> son3Blogs()
        {
            
            return _iBlogDal.listAll().TakeLast(3).ToList(); // son üç tane sıralama // ilk 3 ise Take(3)
        }

        public List<Blog> BlogKategoriYorumListesiAL()
        {
            return _iBlogDal.BlogKategoriYorumListesi();
        }

        public int BlogSayisi(int kategoriID)
        {
            return _iBlogDal.listAll().Where(x=>x.CategoryID==kategoriID).Count();
        }
    }
}
