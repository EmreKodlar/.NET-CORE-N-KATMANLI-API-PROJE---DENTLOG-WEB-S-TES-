using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfContactRepository : GenericRepository<Contact>, IContactDal
    {
    }
}
