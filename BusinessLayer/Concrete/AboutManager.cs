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
    public class AboutManager : IAboutService
    {
        IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void AboutAddBL(About category)
        {
            _aboutDAL.Insert(category);
        }

        public void AboutDelete(About category)
        {
            _aboutDAL.Delete(category);
        }

        public void AboutUpdate(About category)
        {
            _aboutDAL.Update(category);
        }

        public About GetById(int id)
        {
            return _aboutDAL.Get(x => x.AboutId == id);
        }

        public List<About> GetList()
        {
            return _aboutDAL.List();
        }
    }
}
