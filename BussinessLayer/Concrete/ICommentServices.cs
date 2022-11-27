using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Concrete
{
    public interface ICommentServices
    {
        List<Comment> listComments(int id);

        List<Comment> listeleComments();
        void EkleComment(Comment cat);
        void SilComment(Comment cat);
        
        void GuncelleComment(Comment cat);
        Comment SinifGetirComment(int id);
 
    }
}
