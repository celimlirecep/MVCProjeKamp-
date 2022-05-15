using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFHeadingDAL : GenericRepository<Heading>, IHeadingDAL
    {
        Context context = new Context();
        public List<Heading> GetHeadingCombineWriterAndCategory()
        {
            return context.Headings
                .Include(x => x.Category)
                .Include(y => y.Writer)
                .ToList();
                
        }
    }
}
