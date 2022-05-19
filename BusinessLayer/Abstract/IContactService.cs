using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
     public interface IContactService
    {
        List<Contact> GetList();
        void ContactAddBL(Contact category);
        Contact GetById(int id);
        void ContactDelete(Contact category);
        void ContactUpdate(Contact category);
    }
}
