using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();
        void AdminAddBL(Admin admin);
        Admin GetById(int id);
        void AdminDelete(Admin admin);
        void AdminUpdate(Admin admin);
        public Admin Get(Expression<Func<Admin, bool>> filter);
        

    }
}
