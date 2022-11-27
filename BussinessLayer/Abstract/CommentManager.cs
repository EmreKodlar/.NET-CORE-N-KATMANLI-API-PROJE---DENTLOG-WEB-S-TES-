using BussinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Abstract
{
    public class CommentManager : ICommentServices
    {
        ICommentDal _iCommentDal; // Önce tanımla 

        public CommentManager(ICommentDal iCommentDal)
        {
            _iCommentDal = iCommentDal; // sonra  new'lemeden interface'i ata! Artık tüm Generic metotlar bunun içinde.
        }

        public void EkleComment(Comment cat)
        {
            _iCommentDal.Add(cat);
        }

        public void GuncelleComment(Comment cat)
        {
            _iCommentDal.Update(cat);
        }

        public List<Comment> listComments(int id)
        {
            return _iCommentDal.SartliListele(x=>x.BlogID==id); // Hangi blogda yorum varsa ona gitsin
        }

        public List<Comment> listeleComments()
        {
            return _iCommentDal.listAll(); 
        }

        public void SilComment(Comment cat)
        {
            _iCommentDal.Delete(cat);
        }

        public Comment SinifGetirComment(int id)
        {
            return _iCommentDal.getByID(id);
        }

        //public void GuncelleComment(Comment cat)
        //{
        //    _iCommentDal.Update(cat);
        //}



        //public void SilComment(Comment cat)
        //{
        //    _iCommentDal.Delete(cat);
        //}

        //public Comment SinifGetirComment(int id)
        //{
        //    return _iCommentDal.getByID(id);
        //}



    }
}
