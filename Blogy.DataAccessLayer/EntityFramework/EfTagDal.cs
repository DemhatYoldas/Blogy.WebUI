using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogy.DataAccessLayer.Abstract;
using Blogy.DataAccessLayer.Repository;
using Blogy.EntityLayer.Concrete;

namespace Blogy.DataAccessLayer.EntityFramework
{
    public class EfTagDal:GenericRepository<Tag>,ITagDal
    {
    }
}
