using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void ContactAddBL(Contact category)
        {
            _contactDAL.Insert(category);
        }

        public void ContactDelete(Contact category)
        {
            _contactDAL.Delete(category);
        }

        public void ContactUpdate(Contact category)
        {
            _contactDAL.Update(category);
        }

        public Contact GetById(int id)
        {
            return _contactDAL.Get(x => x.ContactId == id);
        }

        public List<Contact> GetList()
        {
            return _contactDAL.List();
        }
    }
}
